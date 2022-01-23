using CoffeeMachineApp.CoffeeMachineServices;
using CoffeeMachineApp.interfaces;
using CoffeeMachineApp.Recipes;
using CoffeeMachineApp.Tanks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp
{
    class CoffeeMachineKrups : CoffeeMachine
    {
        public override string Name => "Krups";

        private MilkTank MilkTank;
        private NonGroundedCoffeeTank NonGroundedCoffeeTank;

        protected int coffeeAmountGrindedAtTime = 50;

        public CoffeeMachineKrups(int waterVolume, int coffeeVolume, int refuseVolume, int milkVolume) : base(waterVolume, coffeeVolume, refuseVolume)
        {
            MilkTank = new MilkTank(milkVolume);
            NonGroundedCoffeeTank = new NonGroundedCoffeeTank(coffeeVolume);

            List<IService> ServicesSpecialForKrupsCoffeeMachine = new List<IService>
            {
                new AddService(MilkTank),
                new AddService(NonGroundedCoffeeTank),
                new CoffeeGrinderService(NonGroundedCoffeeTank,CoffeeTank,coffeeAmountGrindedAtTime),
                new StandartCoffeeMakerService(new AmericanoRecipe(), CoffeeTank, WaterTank, RefuseTank),
                new MilkyCoffeeMakerService(new LatteRecipe(30), CoffeeTank,WaterTank,RefuseTank,MilkTank)
            };

            Services.AddRange(ServicesSpecialForKrupsCoffeeMachine);
        }
    }
}
