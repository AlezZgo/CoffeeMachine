using System;
using System.Collections.Generic;
using System.Text;
using CoffeeMachineApp.interfaces;

namespace CoffeeMachineApp.CoffeeMachineServices
{
    class CleanService : IService
    {
        private Tanks.Tank _tank;

        public CleanService(Tanks.Tank tank)
        {
            _tank = tank;
        }

        public void ExecuteService()
        {
            _tank.MakeEmpty();
            _tank.WriteCurrentTankState();
        }

        public string GetServicePurpose() => $"Clean the {_tank.Name}";

    }
}
