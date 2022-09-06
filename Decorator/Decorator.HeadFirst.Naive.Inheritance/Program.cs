using System.Collections.Immutable;

using Decorator.HeadFirst.Naive.Inheritance.Beverages;
using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;
using Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;
using Decorator.HeadFirst.Naive.Inheritance.Beverages.Factories;
using Decorator.HeadFirst.StarBuzzCoffee.Common;

namespace Decorator.HeadFirst.Naive.Inheritance
{
    public static class Program
    {
        // TODO: notice that adding base beverages or condiments leads to a class explosion
        private static readonly ImmutableDictionary<int, BeverageBase> Selection = new Dictionary<int, BeverageBase>
            {
                [SelectionOptions.DarkRoast] = BeverageFactory.Create<DarkRoast>(),
                [SelectionOptions.Decaf] = BeverageFactory.Create<Decaf>(),
                [SelectionOptions.Espresso] = BeverageFactory.Create<Espresso>(),
                [SelectionOptions.HouseBlend] = BeverageFactory.Create<HouseBlend>(),
                [SelectionOptions.DarkRoastWithSteamedMilk] = BeverageFactory.Create<DarkRoastWithSteamedMilk>(),
                [SelectionOptions.DecafWithSteamedMilk] = BeverageFactory.Create<DecafWithSteamedMilk>(),
                [SelectionOptions.EspressoWithSteamedMilk] = BeverageFactory.Create<EspressoWithSteamedMilk>(),
                [SelectionOptions.HouseBlendWithSteamedMilk] = BeverageFactory.Create<HouseBlendWithSteamedMilk>(),
                [SelectionOptions.DarkRoastWithMocha] = BeverageFactory.Create<DarkRoastWithMocha>(),
                [SelectionOptions.DarkRoastWithSteamedMilkAndMocha] = BeverageFactory.Create<DarkRoastWithSteamedMilkAndMocha>(),
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
