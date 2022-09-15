﻿using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Names;
using Factory.HeadFirst.Pizzeria.Factories.Ingredients.Factories;
using Factory.HeadFirst.Pizzeria.Factories.Stores.Base;

namespace Factory.HeadFirst.Pizzeria.Factories.Stores;

public class ChicagoPizzaStore :
    PizzaStoreBase
{
    public ChicagoPizzaStore()
        : base(PizzaStyle.Chicago, new ChicagoPizzaIngredientFactory())
    {
    }
}
