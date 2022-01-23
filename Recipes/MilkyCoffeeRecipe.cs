using CoffeeMachineApp.Tanks;
using System;
using System.Collections.Generic;
using System.Text;
using CoffeeMachineApp.Errors;

namespace CoffeeMachineApp.Recipes
{
    abstract class MilkyCoffeeRecipe : CoffeeRecipe
    {
        private int _milkAmount;
        private const int _maxMilkValue = 100;

        public int MilkAmount
        {
            get => _milkAmount;
            set { _milkAmount = value;} 
        }

    }
}
