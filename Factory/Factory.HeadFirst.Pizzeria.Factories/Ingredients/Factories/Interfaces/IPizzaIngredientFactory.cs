using System.Collections.Immutable;

using Factory.HeadFirst.Pizzeria.Common.Ingredients.Doughs.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Sauces.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Cheeses.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Fishes.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Meats.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Vegetables.Base;

namespace Factory.HeadFirst.Pizzeria.Factories.Ingredients.Factories.Interfaces;

/// <summary>
/// This is the interface of the abstract factory.
/// </summary>
public interface IPizzaIngredientFactory
{
    DoughBase CreateDough();

    SauceBase CreateSauce();

    CheeseBase CreateCheese();

    ImmutableList<VegetableBase> CreateVegetables();

    MeatBase CreatePepperoni();

    FishBase CreateClams();
}
