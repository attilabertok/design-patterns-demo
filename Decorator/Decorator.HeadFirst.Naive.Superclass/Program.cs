using System.Collections.Immutable;

using Decorator.HeadFirst.Naive.Superclass.Beverages;
using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;
using Decorator.HeadFirst.Naive.Superclass.Beverages.Coffees;
using Decorator.HeadFirst.Naive.Superclass.Beverages.Factories;

namespace Decorator.HeadFirst.Naive.Superclass
{
    public static class Program
    {
        private static readonly ImmutableDictionary<int, BeverageBase> Selection = new Dictionary<int, BeverageBase>
        {
            [SelectionOptions.DarkRoast] = BeverageFactory.Create<DarkRoast>(),
            [SelectionOptions.Decaf] = BeverageFactory.Create<Decaf>(),
            [SelectionOptions.Espresso] = BeverageFactory.Create<Espresso>(),
            [SelectionOptions.HouseBlend] = BeverageFactory.Create<HouseBlend>(),
            [SelectionOptions.DarkRoastWithSteamedMilk] = BeverageFactory.Create<DarkRoast>().WithSteamedMilk(),
            [SelectionOptions.DecafWithSteamedMilk] = BeverageFactory.Create<Decaf>().WithSteamedMilk(),
            [SelectionOptions.EspressoWithSteamedMilk] = BeverageFactory.Create<Espresso>().WithSteamedMilk(),
            [SelectionOptions.HouseBlendWithSteamedMilk] = BeverageFactory.Create<HouseBlend>().WithSteamedMilk(),
            [SelectionOptions.DarkRoastWithMocha] = BeverageFactory.Create<DarkRoast>().WithMocha(),
            [SelectionOptions.DarkRoastWithSteamedMilkAndMocha] = BeverageFactory.Create<DarkRoast>().WithSteamedMilk().WithMocha(),
            [SelectionOptions.Exit] = BeverageFactory.Create<NullBeverage>()
        }.ToImmutableDictionary();

        public static void Main()
        {
            Console.WriteLine("Hello, and welcome to StarBuzz coffee! What can I serve you with today?");
            int selection;
            decimal grandTotal = 0;
            do
            {
                DisplaySelection();
                while (!int.TryParse(Console.ReadLine(), out selection) && !Selection.ContainsKey(selection))
                {
                    Console.WriteLine("Sorry, I'm not sure I caught that. Could you please repeat it?");
                    DisplaySelection();
                }

                if (selection != SelectionOptions.Exit)
                {
                    Console.WriteLine($"One {Selection[selection].Description} coming up! Anything else?");
                    grandTotal += Selection[selection].CalculateCost();
                }
            }
            while (selection != SelectionOptions.Exit);

            Console.WriteLine($"Thank you. {(grandTotal > 0 ? "here you go, your grand total is $" + grandTotal : string.Empty)}");
        }

        private static void DisplaySelection()
        {
            foreach (var item in Selection)
            {
                Console.WriteLine($"{item.Key} : {item.Value.Description} - ${item.Value.CalculateCost()}");
            }

            Console.WriteLine();
        }
    }
}
