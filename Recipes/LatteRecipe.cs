using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Recipes
{
    class LatteRecipe : MilkyCoffeeRecipe
    {

        private EspressoRecipe espressoRecipe = new EspressoRecipe();

        public LatteRecipe(int milkAmount)
        {
            MilkAmount = milkAmount;
        }

        public override int CoffeeAmount => espressoRecipe.CoffeeAmount;
        public override int WaterAmount => espressoRecipe.WaterAmount;

        public override string Name => "Latte";


    }
}
