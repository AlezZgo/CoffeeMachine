using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Recipes
{
    class AmericanoRecipe : CoffeeRecipe
    {
        public override string Name => "Americano";

        public override int CoffeeAmount => 22;

        public override int WaterAmount => 100;
    }
}
