using CoffeeMachineApp.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using CoffeeMachineApp.CoffeeMachineInputOutputController;

namespace CoffeeMachineApp.IOSerivice
{
    class OutputController : IOController
    {
        public OutputController(List<IService> services) : base(services)
        {

        }

        public void ShowPossibilities()
        {
            for(int i=0; i < _services.Count; i++)
            {
                Console.WriteLine($"Press {i} to {_services[i].GetServicePurpose()}");
            }
        }

    }
}
