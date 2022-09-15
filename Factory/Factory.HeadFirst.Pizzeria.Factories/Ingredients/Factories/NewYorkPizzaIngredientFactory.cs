using System.Collections.Immutable;

using Factory.HeadFirst.Pizzeria.Common.Ingredients.Doughs;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Doughs.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Sauces;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Sauces.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Cheeses;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Cheeses.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Fishes;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Fishes.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Meats;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Meats.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Vegetables;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Vegetables.Base;
using Factory.HeadFirst.Pizzeria.Factories.Ingredients.Factories.Interfaces;

namespace Factory.HeadFirst.Pizzeria.Factories.Ingredients.Factories;

/// <summary>
/// This is a concrete factory implementation of the abstract factory interface.
/// </summary>
public class NewYorkPizzaIngredientFactory : IPizzaIngredientFactory
{
    public DoughBase CreateDough()
    {
        return new ThinCrustDough();
    }

    public SauceBase CreateSauce()
    {
        return new MarinaraSauce();
    }

    public CheeseBase CreateCheese()
    {
        return new ReggianoCheese();
    }

    public ImmutableList<VegetableBase> CreateVegetables()
    {
        return new List<VegetableBase>
        {
            new Garlic(),
            new Onion(),
            new Mushroom(),
            new RedPepper()
        }.ToImmutableList();
    }

    public MeatBase CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public FishBase CreateClams()
    {
        return new FreshClams();
    }
}
