using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Exceptions
{
    class WrongClassUsingException : Exception
    {
        public WrongClassUsingException()
        {
            Console.WriteLine("Wrong using class");
        }

        public WrongClassUsingException(string message) : base(message)
        {
            Console.WriteLine("Wrong using class \n" + message);
        }
    }
}
