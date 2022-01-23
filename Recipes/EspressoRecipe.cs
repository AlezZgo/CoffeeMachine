using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Recipes
{
    class EspressoRecipe : CoffeeRecipe
    {
        public override int CoffeeAmount { get => 22; }
        public override int WaterAmount { get => 30;  }

        public override string Name => "Espresso";


    }
}
