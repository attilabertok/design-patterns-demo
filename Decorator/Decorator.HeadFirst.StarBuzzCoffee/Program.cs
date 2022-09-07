using System.Collections.Immutable;

using Decorator.HeadFirst.StarBuzzCoffee.Beverages;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Coffees;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments.Builder;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Factories;
using Decorator.HeadFirst.StarBuzzCoffee.Common;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Infrastructure;
using Decorator.HeadFirst.StarBuzzCoffee.Infrastructure;

namespace Decorator.HeadFirst.StarBuzzCoffee
{
    public static class Program
    {
        private static readonly ImmutableDictionary<int, Func<IBeverage>> CoffeeSelection = new Dictionary<int, Func<IBeverage>>
        {
            [SelectionOptions.DarkRoast] = BeverageFactory.Create<DarkRoast>,
            [SelectionOptions.Decaf] = BeverageFactory.Create<Decaf>,
            [SelectionOptions.Espresso] = BeverageFactory.Create<Espresso>,
            [SelectionOptions.HouseBlend] = BeverageFactory.Create<HouseBlend>,
            [SelectionOptions.Exit] = BeverageFactory.Create<NullBeverage>
        }.ToImmutableDictionary();

        private static readonly ImmutableDictionary<int, CondimentBuilder> CondimentSelection = new Dictionary<int, CondimentBuilder>
        {
            [SelectionOptions.Mocha] = CondimentBuilder.Mocha,
            [SelectionOptions.Whip] = CondimentBuilder.Whip,
            [SelectionOptions.Soy] = CondimentBuilder.Soy,
            [SelectionOptions.SteamedMilk] = CondimentBuilder.SteamedMilk,
            [SelectionOptions.Exit] = CondimentBuilder.Nothing
        }.ToImmutableDictionary();

        private static readonly ImmutableDictionary<int, Size> Sizes = Enumerable.Range(0, Size.Values.Count)
            .ToImmutableDictionary(i => i, i => Size.Values[i]);

        private static decimal grandTotal;

        public static void Main()
        {
            Console.WriteLine(Message.Greeting);
            int selection;
            do
            {
                DisplayCoffeeSelection();
                selection = GetSelection();

                if (selection != SelectionOptions.Exit)
                {
                    var beverage = SetupBeverage(selection);
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
                DisplayCondimentSelection(beverage.Size);
                condimentSelection = GetCondimentSelection(beverage);

                if (condimentSelection != SelectionOptions.Exit)
                {
                    beverage = CondimentSelection[condimentSelection].Build(beverage);
                    Console.WriteLine($"That is a {beverage.Description} so far. Anything else?");
                }
            }
            while (condimentSelection != SelectionOptions.Exit);

            return beverage;
        }

        private static IBeverage SetupBeverage(int selection)
        {
            var beverage = CoffeeSelection[selection]();
            SetSize(beverage);
            Console.WriteLine($"One {beverage.Size} {beverage.Description} coming up! Would you like to add something to that?");
            beverage = AddCondiment(beverage);
            Console.WriteLine($"Alright, one {beverage.Size} {beverage.Description} coming up! Anything else?");

            return beverage;
        }

        private static void SetSize(IBeverage beverage)
        {
            Console.WriteLine($"One {beverage.Description}. What size would you like?");
            beverage.Size = Sizes[GetSize(beverage)];
        }

        private static int GetSize(IBeverage beverage)
        {
            DisplaySizes(beverage);
            return UserIo.AskUntilValid(Sizes.Keys.ToHashSet(), Message.RepeatSelection, () => DisplaySizes(beverage));
        }

        private static void DisplayCoffeeSelection()
        {
            foreach (var item in CoffeeSelection)
            {
                var beverage = item.Value();
                var costRange = beverage.CalculateCostRange();

                Console.WriteLine($"{item.Key} : {beverage.Description} (${costRange.Min} - ${costRange.Max})");
            }

            Console.WriteLine();
        }

        private static void DisplayCondimentSelection(Size size)
        {
            foreach (var item in CondimentSelection)
            {
                Console.WriteLine($"{item.Key} : {item.Value.Data.Description} - ${item.Value.Data.Cost[size]}");
            }

            Console.WriteLine();
        }

        private static int GetSelection()
        {
            return UserIo.AskUntilValid(CoffeeSelection.Keys.ToHashSet(), Message.RepeatSelection, DisplayCoffeeSelection);
        }

        private static int GetCondimentSelection(IBeverage beverage)
        {
            return UserIo.AskUntilValid(CondimentSelection.Keys.ToHashSet(), Message.RepeatSelection, () => DisplayCondimentSelection(beverage.Size));
        }

        private static void DisplaySizes(IBeverage beverage)
        {
            foreach (var item in Sizes)
            {
                Console.WriteLine($"{item.Key} : {item.Value.Value} (${beverage.CalculateCost(item.Value)})");
            }

            Console.WriteLine();
        }
    }
}
