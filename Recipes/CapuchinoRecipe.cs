using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Recipes
{
    class CapuchinoRecipe : MilkyCoffeeRecipe
    {
        private EspressoRecipe espressoRecipe = new EspressoRecipe();

        public CapuchinoRecipe(int milkAmount)
        {
            MilkAmount = milkAmount;
        }

        public override int CoffeeAmount => espressoRecipe.CoffeeAmount;
        public override int WaterAmount => espressoRecipe.WaterAmount;

        public override string Name => "Capuchino";


    }
}
