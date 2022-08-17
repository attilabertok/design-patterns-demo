using Strategy.HeadFirst.Common.Infrastructure;
using Strategy.HeadFirst.Final.Ducks;
using Strategy.HeadFirst.Final.Ducks.Base;

namespace Strategy.HeadFirst.Final
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

            var decoy = (DecoyDuck)ducks.Last();
            DuckExtensions.Describe(decoy.GetType().Name, decoy.Fly);
            decoy.AttachRocket();
            DuckExtensions.Describe(decoy.GetType().Name, decoy.Fly);
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
