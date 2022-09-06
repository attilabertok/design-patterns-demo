using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages.Factories;

public static class BeverageFactory
{
    public static T Create<T>()
        where T : BeverageBase, new()
    {
        return new T();
    }
}
