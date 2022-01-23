using System;
using System.Collections.Generic;
using CoffeeMachineApp.CoffeeMachineServices;
using CoffeeMachineApp.Recipes;
using CoffeeMachineApp.Tanks;

namespace CoffeeMachineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachineKrups coffeeMachineKrups = new CoffeeMachineKrups(400, 400, 400, 400);
            coffeeMachineKrups.TurnOn();
        }

    }
}
