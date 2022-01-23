using CoffeeMachineApp.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.CoffeeMachineServices
{
    class AddService : IService
    {
        private Tanks.Tank _tank;

        public AddService(Tanks.Tank tank)
        {
            _tank = tank;
        }

        public void ExecuteService()
        {
            _tank.Fill();
            _tank.WriteCurrentTankState();
        }

        public string GetServicePurpose() => $"Fill the {_tank.Name}";

    }
}
