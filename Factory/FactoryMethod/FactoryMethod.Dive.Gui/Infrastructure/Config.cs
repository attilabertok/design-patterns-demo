using FactoryMethod.Dive.Gui.Infrastructure.Interfaces;

namespace FactoryMethod.Dive.Gui.Infrastructure
{
    public class Config :
        IConfig
    {
        public OpSystem OpSystem { get; } = OpSystem.Windows;
    }
}
