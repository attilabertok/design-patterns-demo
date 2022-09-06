using System.Collections.Immutable;

using Decorator.HeadFirst.StarBuzzCoffee.Beverages;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Coffees;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments.Builder;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Factories;
using Decorator.HeadFirst.StarBuzzCoffee.Common;

namespace Decorator.HeadFirst.StarBuzzCoffee
{
    public static class Program
    {
        private static readonly ImmutableDictionary<int, IBeverage> CoffeeSelection = new Dictionary<int, IBeverage>
        {
            [SelectionOptions.DarkRoast] = BeverageFactory.Create<DarkRoast>(),
            [SelectionOptions.Decaf] = BeverageFactory.Create<Decaf>(),
            [SelectionOptions.Espresso] = BeverageFactory.Create<Espresso>(),
            [SelectionOptions.HouseBlend] = BeverageFactory.Create<HouseBlend>(),
            [SelectionOptions.Exit] = BeverageFactory.Create<NullBeverage>()
        }.ToImmutableDictionary();

        private static readonly ImmutableDictionary<int, CondimentBuilder> CondimentSelection = new Dictionary<int, CondimentBuilder>
        {
            [SelectionOptions.Mocha] = CondimentBuilder.Mocha,
            [SelectionOptions.Whip] = CondimentBuilder.Whip,
            [SelectionOptions.Soy] = CondimentBuilder.Soy,
            [SelectionOptions.SteamedMilk] = CondimentBuilder.SteamedMilk,
            [SelectionOptions.Exit] = CondimentBuilder.Nothing
        }.ToImmutableDictionary();

        public static void Main()
        {
            Console.WriteLine("Hello, and welcome to StarBuzz coffee! What can I serve you with today?");
            int selection;
            decimal grandTotal = 0;
            do
            {
                DisplayCoffeeSelection();
                while (!int.TryParse(Console.ReadLine(), out selection) && !CoffeeSelection.ContainsKey(selection))
                {
                    Console.WriteLine("Sorry, I'm not sure I caught that. Could you please repeat it?");
                    DisplayCoffeeSelection();
                }

                if (selection != SelectionOptions.Exit)
                {
                    var beverage = CoffeeSelection[selection];
                    Console.WriteLine($"One {beverage.Description} coming up! Would you like to add something to that?");
                    beverage = AddCondiment(beverage);

                    grandTotal += beverage.CalculateCost();
                }
            }
            while (selection != SelectionOptions.Exit);

            Console.WriteLine($"Thank you. {(grandTotal > 0 ? "here you go, your grand total is $" + grandTotal : string.Empty)}");
        }

        private static IBeverage AddCondiment(IBeverage beverage)
        {
            int condimentSelection;
            do
            {
                DisplayCondimentSelection();
                while (!int.TryParse(Console.ReadLine(), out condimentSelection)
                       && !CondimentSelection.ContainsKey(condimentSelection))
                {
                    Console.WriteLine("Sorry, I'm not sure I caught that. Could you please repeat it?");
                    DisplayCondimentSelection();
                }

                if (condimentSelection != SelectionOptions.Exit)
                {
                    beverage = CondimentSelection[condimentSelection].Build(beverage);
                    Console.WriteLine($"That is a {beverage.Description} so far. Anything else?");
                }
            }
            while (condimentSelection != SelectionOptions.Exit);

            return beverage;
        }

        private static void DisplayCoffeeSelection()
        {
            foreach (var item in CoffeeSelection)
            {
                Console.WriteLine($"{item.Key} : {item.Value.Description} - ${item.Value.CalculateCost()}");
            }

            Console.WriteLine();
        }

        private static void DisplayCondimentSelection()
        {
            foreach (var item in CondimentSelection)
            {
                Console.WriteLine($"{item.Key} : {item.Value.Data.Description} - ${item.Value.Data.Cost}");
            }

            Console.WriteLine();
        }
    }
}
