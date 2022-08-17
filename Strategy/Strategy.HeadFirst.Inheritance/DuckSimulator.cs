using Strategy.HeadFirst.Common.Infrastructure;
using Strategy.HeadFirst.Inheritance.Behaviors;
using Strategy.HeadFirst.Inheritance.Ducks;
using Strategy.HeadFirst.Inheritance.Ducks.Base;

namespace Strategy.HeadFirst.Inheritance
{
    public static class DuckSimulator
    {
        public static void Main()
        {
            var ducks = new List<DuckBase>
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck()
            };

            foreach (var duck in ducks)
            {
                DoDuckThings(duck);
            }
        }

        public static string QuackFallback()
        {
            return "<< Silence... >>";
        }

        public static string FlyFallback()
        {
            return "Falling like a rock.";
        }

        private static void DoDuckThings(DuckBase duck)
        {
            DuckExtensions.Describe(duck.GetType().Name, duck.Display);

            // uh-oh
            Func<string> quackMethod = duck is IQuackable quackable
                ? () => quackable.Quack()
                : QuackFallback;

            DuckExtensions.Describe(duck.GetType().Name, quackMethod);
            DuckExtensions.Describe(duck.GetType().Name, duck.Swim);

            // added recently
            // uh-oh
            Func<string> flyMethod = duck is IFlyable flyable
                ? () => flyable.Fly()
                : FlyFallback;
            DuckExtensions.Describe(duck.GetType().Name, flyMethod);
            Console.WriteLine();
        }
    }
}
