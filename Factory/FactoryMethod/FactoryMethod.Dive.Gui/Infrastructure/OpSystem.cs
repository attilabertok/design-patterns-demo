namespace FactoryMethod.Dive.Gui.Infrastructure
{
    public sealed partial class OpSystem :
        IEquatable<OpSystem>
    {
        private OpSystem(string name)
        {
            Name = name;
        }

        public static OpSystem Windows { get; } = new(OpSystemName.WindowsOs);

        public static OpSystem Web { get; } = new(OpSystemName.WebOs);

        public string Name { get; }

        private static class OpSystemName
        {
            public const string WindowsOs = "Windows";
            public const string WebOs = "web";
        }
    }
}
