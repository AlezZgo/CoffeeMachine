using CoffeeMachineApp.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using CoffeeMachineApp.Exceptions;
using CoffeeMachineApp.Errors;

namespace CoffeeMachineApp.CoffeeMachineInputOutputController
{
    class InputController : IOController
    {

        public InputController(List<IService> services) : base(services)
        {

        }

        public void ActivateInputListener()
        {
            int inputed = 0;
            int.TryParse(Console.ReadLine(),out inputed);

            try
            {
                _services[inputed].ExecuteService();
            }catch
            {
                IncorrectInputError incorrectBoundariesError = new IncorrectInputError(inputed, 0, _services.Count);
            }

            ActivateInputListener();
        }


    }
}
