using System.Collections.Immutable;

using Decorator.HeadFirst.Naive.Inheritance.Beverages;
using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;
using Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;
using Decorator.HeadFirst.Naive.Inheritance.Beverages.Factories;
using Decorator.HeadFirst.Naive.Inheritance.Infrastructure;
using Decorator.HeadFirst.StarBuzzCoffee.Common;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Infrastructure;

namespace Decorator.HeadFirst.Naive.Inheritance
{
    public static class Program
    {
        // TODO: notice that adding base beverages or condiments leads to a class explosion
        private static readonly ImmutableDictionary<int, Func<BeverageBase>> Selection = new Dictionary<int, Func<BeverageBase>>
            {
                [SelectionOptions.DarkRoast] = BeverageFactory.Create<DarkRoast>,
                [SelectionOptions.Decaf] = BeverageFactory.Create<Decaf>,
                [SelectionOptions.Espresso] = BeverageFactory.Create<Espresso>,
                [SelectionOptions.HouseBlend] = BeverageFactory.Create<HouseBlend>,
                [SelectionOptions.DarkRoastWithSteamedMilk] = BeverageFactory.Create<DarkRoastWithSteamedMilk>,
                [SelectionOptions.DecafWithSteamedMilk] = BeverageFactory.Create<DecafWithSteamedMilk>,
                [SelectionOptions.EspressoWithSteamedMilk] = BeverageFactory.Create<EspressoWithSteamedMilk>,
                [SelectionOptions.HouseBlendWithSteamedMilk] = BeverageFactory.Create<HouseBlendWithSteamedMilk>,
                [SelectionOptions.DarkRoastWithMocha] = BeverageFactory.Create<DarkRoastWithMocha>,
                [SelectionOptions.DarkRoastWithSteamedMilkAndMocha] = BeverageFactory.Create<DarkRoastWithSteamedMilkAndMocha>,
                [SelectionOptions.Exit] = BeverageFactory.Create<NullBeverage>
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
                DisplaySelection();
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

        private static int GetSelection()
        {
            return UserIo.AskUntilValid(Selection.Keys.ToHashSet(), Message.RepeatSelection, DisplaySelection);
        }

        private static BeverageBase SetupBeverage(int selection)
        {
            var beverage = Selection[selection].Invoke();
            SetSize(beverage);
            Console.WriteLine($"Alright, one {beverage.Size} {beverage.Description} coming up! Anything else?");

            return beverage;
        }

        private static void SetSize(BeverageBase beverage)
        {
            Console.WriteLine($"One {beverage.Description}. What size would you like?");
            beverage.Size = Sizes[GetSize(beverage)];
        }

        private static int GetSize(BeverageBase beverage)
        {
            DisplaySizes(beverage);
            return UserIo.AskUntilValid(Sizes.Keys.ToHashSet(), Message.RepeatSelection, () => DisplaySizes(beverage));
        }

        private static void DisplaySelection()
        {
            foreach (var item in Selection)
            {
                var beverage = item.Value.Invoke();
                var costRange = beverage.CalculateCostRange();

                Console.WriteLine($"{item.Key} : {beverage.Description} (${costRange.Min} - ${costRange.Max})");
            }

            Console.WriteLine();
        }

        private static void DisplaySizes(BeverageBase beverage)
        {
            foreach (var item in Sizes)
            {
                Console.WriteLine($"{item.Key} : {item.Value.Value} (${beverage.CalculateCost(item.Value)})");
            }

            Console.WriteLine();
        }
    }
}
