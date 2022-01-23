using System;
using System.Collections.Generic;
using System.Text;
using CoffeeMachineApp.interfaces;
    
namespace CoffeeMachineApp.CoffeeMachineServices
{
    class TurnOffService : IService
    {
        public void ExecuteService() => Environment.Exit(0);

        public string GetServicePurpose() => "Turn off";
    }
}
