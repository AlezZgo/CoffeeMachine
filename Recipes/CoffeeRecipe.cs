using System;
using System.Collections.Generic;
using CoffeeMachineApp.Tanks;
 
namespace CoffeeMachineApp.Recipes
{
    abstract class CoffeeRecipe 
    {
        public abstract string Name { get; }
        public abstract int CoffeeAmount { get;  }
        public abstract int WaterAmount { get;  }

        public virtual void MakeCoffee(CoffeeTank coffeeTank,WaterTank waterTank,RefuseTank refuseTank)
        {
            if(CheckIfNotEnough(coffeeTank.CurrentVolume, CoffeeAmount)) 
                return;
            if (CheckIfNotEnough(waterTank.CurrentVolume, WaterAmount))
                return;
            if (CheckIfNotOverfilled(refuseTank.CurrentVolume, CoffeeAmount))
                return;
            coffeeTank.Get(CoffeeAmount);
            waterTank.Get(WaterAmount);
            refuseTank.Add(CoffeeAmount);
        }

        public bool CheckIfNotEnough(int current, int required) => required > current;

        public bool CheckIfNotOverfilled(int freeSpace, int required) => freeSpace >= required;

    }
}
