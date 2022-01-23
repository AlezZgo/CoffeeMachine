using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Errors
{
    class NotEnoughError
    {
        public NotEnoughError(string name, int current, int required)
        {
            Console.WriteLine($"Not Enough {name} " +
                $"required: {required} " +
                $"current state: {current}");
        }
    }
}
