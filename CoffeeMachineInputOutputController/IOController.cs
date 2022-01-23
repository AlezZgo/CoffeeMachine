using CoffeeMachineApp.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using CoffeeMachineApp.Exceptions;

namespace CoffeeMachineApp.CoffeeMachineInputOutputController
{
    abstract class IOController
    {
        protected List<IService> _services;

        public IOController(List<IService> services)
        {
            _services = services;
        }
    }
}
