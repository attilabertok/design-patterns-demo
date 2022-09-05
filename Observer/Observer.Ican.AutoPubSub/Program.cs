using System.Collections;
using System.Reflection;

using Autofac;
using Observer.Ican.AutoPubSub.ConsoleLogging.Services;
using Observer.Ican.AutoPubSub.Infrastructure.Eventing;
using Observer.Ican.AutoPubSub.UserInterface.Controls;

namespace Observer.Ican.AutoPubSub
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: other DI frameworks lack support for some of these features, this cannot be done in e.g. Microsoft netCore DI
            var builder = new ContainerBuilder();

            var assembly = typeof(Program).Assembly;

            // TODO: singleInstance is not a reasonable limitation
            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(ISend<>))
                .SingleInstance();

            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.GetInterfaces().Any(IsMessageHandler))
                .OnActivated(act =>
                {
                    var instanceType = act.Instance.GetType();
                    var interfaces = instanceType.GetInterfaces().Where(IsMessageHandler);
                    foreach (var i in interfaces)
                    {
                        var argumentType = i.GetGenericArguments()[0];
                        var senderType = typeof(ISend<>).MakeGenericType(argumentType);
                        var allSendersTypes = typeof(IEnumerable<>)
                            .MakeGenericType(senderType);

                        // TODO: only parameterless constructors work here
                        var allSenders = (IEnumerable)act.Context.Resolve(allSendersTypes);
                        foreach (var sender in allSenders)
                        {
                            var messages = sender.GetType().GetEvents(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                                .Where(e => e.Name.EndsWith("Sender") && e.EventHandlerType!.GetGenericArguments()[0] == argumentType)
                                .ToList();
                            foreach (var eventInfo in messages)
                            {
                                var eventInfoTypeParameter = eventInfo.EventHandlerType!.GetGenericArguments()[0];

                                // TODO: string filter is ugly, but getting the name of a Handle method of an open generic is difficult
                                var handleMethods = instanceType.GetMethods().Where(m => m.Name == "Handle");
                                var handleMethod = handleMethods.First(m => m.GetParameters()[1].ParameterType == eventInfoTypeParameter);
                                var handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, null, handleMethod);
                                var addMethod = eventInfo.GetAddMethod(true);
                                addMethod!.Invoke(sender, new object?[] { handler });
                            }
                        }
                    }
                })
                .SingleInstance()
                .AsSelf();

            var container = builder.Build();

            var button = container.Resolve<Button>();
            button.Caption = "firstButton";
            button.Name = "button1";
            var textBox = container.Resolve<TextBox>();
            textBox.Content = "firstTextBox";
            textBox.Name = "textBox1";
            var logger = container.Resolve<ControlEventLogger>();

            button.EmitClicks(3);
            textBox.EmitContentChanged();
            textBox.EmitClicks(2);
        }

        private static bool IsMessageHandler(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IHandle<>);
        }
    }
}
