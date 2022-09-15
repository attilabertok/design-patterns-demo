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
public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public DoughBase CreateDough()
    {
        return new ThickCrustDough();
    }

    public SauceBase CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public CheeseBase CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public ImmutableList<VegetableBase> CreateVegetables()
    {
        return new List<VegetableBase>
        {
            new BlackOlives(),
            new Spinach(),
            new Eggplant()
        }.ToImmutableList();
    }

    public MeatBase CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public FishBase CreateClams()
    {
        return new FrozenClams();
    }
}
