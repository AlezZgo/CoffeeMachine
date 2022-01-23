using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Errors
{
    class IncorrectInputError
    {
        public IncorrectInputError(int inputed, int lowerBound, int upperBound)
        {
            Console.WriteLine($"Wrong Input value " +
            $"It was {inputed} but it is gonna be " +
            $"in range between {lowerBound} and {upperBound}");
        }
    }
}
