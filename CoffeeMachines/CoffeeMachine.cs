using System;
using System.Collections.Generic;
using System.Text;
using CoffeeMachineApp.interfaces;
using CoffeeMachineApp.Tanks;
using CoffeeMachineApp.CoffeeMachineServices;
using CoffeeMachineApp.CoffeeMachineInputOutputController;
using CoffeeMachineApp.IOSerivice;

namespace CoffeeMachineApp
{

    abstract class CoffeeMachine 
    {
        public abstract string Name { get; }

        protected WaterTank WaterTank { get; set; }
        protected CoffeeTank CoffeeTank { get; set; }
        protected RefuseTank RefuseTank { get; set; }

        protected List<IService> Services;

        protected InputController InputController;
        protected OutputController OutputController;

        public CoffeeMachine(int waterVolume, int coffeeVolume, int refuseVolume)
        {
            WaterTank = new WaterTank(waterVolume);
            CoffeeTank = new CoffeeTank(coffeeVolume);
            RefuseTank = new RefuseTank(refuseVolume);

            Services = new List<IService>
            {
                new TurnOffService(),
                new CleanService(RefuseTank),
                new AddService(CoffeeTank),
                new AddService(WaterTank)
            };

            OutputController = new OutputController(Services);
            InputController = new InputController(Services);
        }

        public void TurnOn()
        {
            OutputController.ShowPossibilities();
            InputController.ActivateInputListener();
        }
    }
}
