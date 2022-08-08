using Strategy.HeadFirst.Common.Infrastructure;
using Strategy.HeadFirst.Naive.Ducks;
using Strategy.HeadFirst.Naive.Ducks.Base;

namespace Strategy.HeadFirst.Naive
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

        private static void DoDuckThings(DuckBase duck)
        {
            DuckExtensions.Describe(duck.GetType().Name, duck.Display);
            DuckExtensions.Describe(duck.GetType().Name, duck.Quack);
            DuckExtensions.Describe(duck.GetType().Name, duck.Swim);

            // added recently
            DuckExtensions.Describe(duck.GetType().Name, duck.Fly);
            Console.WriteLine();
        }
    }
}