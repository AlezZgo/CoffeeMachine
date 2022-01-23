using System;
using System.Collections.Generic;
using System.Text;
using CoffeeMachineApp.Tanks;
using CoffeeMachineApp.interfaces;
using CoffeeMachineApp.CoffeeMachineServices;
using CoffeeMachineApp.Recipes;

namespace CoffeeMachineApp
{
    class CoffeeMachineSony : CoffeeMachinePhillips
    {
        private MilkTank MilkTank;

        public CoffeeMachineSony(int waterVolume, int coffeeVolume, int refuseVolume, int milkVolume) : base(waterVolume, coffeeVolume, refuseVolume)
        {
            MilkTank = new MilkTank(milkVolume);

            List<IService> ServicesSpecialForSonyCoffeeMachine = new List<IService>
            {
                new AddService(MilkTank),
                new MilkyCoffeeMakerService(new LatteRecipe(30), CoffeeTank,WaterTank,RefuseTank,MilkTank),
                new MilkyCoffeeMakerService(new CapuchinoRecipe(30), CoffeeTank,WaterTank,RefuseTank,MilkTank)
            };

            Services.AddRange(ServicesSpecialForSonyCoffeeMachine);
        }

        public override string Name => "Sony";
    }
}
