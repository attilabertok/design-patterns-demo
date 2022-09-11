using Bogus;
using Decorator.GoF.Windowing.Components;
using Decorator.GoF.Windowing.Components.Base;
using Decorator.GoF.Windowing.Components.Decorators.Bordering;
using Decorator.GoF.Windowing.Components.Decorators.Scrolling;

namespace Decorator.GoF.Windowing
{
    public static class Program
    {
        public static void Main()
        {
            var data = string.Join(Environment.NewLine, new Faker().Rant.Reviews("Decorator", 5));
            IVisualComponent textView = new TextView
            {
                Content = data
            };

            Console.WriteLine(">> Undecorated TextView:");
            textView.Draw();
            Console.ReadLine();

            Console.WriteLine(">> Undecorated TextView, resized");
            textView.Resize(80, 8);
            textView.Draw();
            Console.ReadLine();

            Console.WriteLine(">> Border-decorated TextView");
            var borderedTextView = new BorderDecorator(new TextView
            {
                Content = data
            });
            borderedTextView.Draw();
            Console.ReadLine();

            Console.WriteLine(">> Border-decorated TextView, resized");
            borderedTextView.Resize(80, 8);
            borderedTextView.Draw();
            Console.ReadLine();

            Console.WriteLine(">> Scrollbar-decorated TextView");
            var scrollableTextView = new ScrollDecorator(new TextView
            {
                Content = data
            });
            scrollableTextView.Draw();
            Console.ReadLine();

            Console.WriteLine(">> Scrollbar-decorated TextView, resized");
            scrollableTextView.Resize(80, 8);
            scrollableTextView.Draw();
            Console.ReadLine();

            Console.WriteLine(">> Scrollbar-decorated, bordered TextView");
            var fullTextView = new BorderDecorator(new ScrollDecorator(new TextView
            {
                Content = data
            }));
            fullTextView.Draw();
            Console.ReadLine();

            Console.WriteLine(">> Scrollbar-decorated, double bordered TextView");
            var doubleTextView = new BorderDecorator(new BorderDecorator(new ScrollDecorator(new TextView
            {
                Content = data
            })));
            scrollableTextView.Resize(80, 8);
            doubleTextView.Draw();
        }
    }
}
