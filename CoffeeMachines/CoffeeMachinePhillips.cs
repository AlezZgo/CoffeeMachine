using System;
using CoffeeMachineApp.interfaces;
using CoffeeMachineApp.Tanks;
using CoffeeMachineApp.CoffeeMachineServices;
using CoffeeMachineApp.Recipes;
using System.Collections.Generic;
using CoffeeMachineApp.CoffeeMachineInputOutputController;

namespace CoffeeMachineApp
{
    class CoffeeMachinePhillips : CoffeeMachine
    {
        public override string Name
        {
            get => "Phillips CoffeeMachine";
        }

        public CoffeeMachinePhillips(int waterVolume, int coffeeVolume, int refuseVolume)
            : base(waterVolume, coffeeVolume, refuseVolume)
        {
            List<StandartCoffeeMakerService> coffeeList = new List<StandartCoffeeMakerService>
            {
                new StandartCoffeeMakerService(new EspressoRecipe(), CoffeeTank, WaterTank, RefuseTank),
                new StandartCoffeeMakerService(new AmericanoRecipe(), CoffeeTank, WaterTank, RefuseTank)
            };
            Services.AddRange(coffeeList);
        }


    }
}