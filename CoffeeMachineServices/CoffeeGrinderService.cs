using CoffeeMachineApp.Errors;
using CoffeeMachineApp.interfaces;
using CoffeeMachineApp.Tanks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.CoffeeMachineServices
{
    class CoffeeGrinderService : IService
    {
        private CoffeeTank _coffeeTank;
        private NonGroundedCoffeeTank _nonGroundedCoffeeTank;
        private int _coffeeAmountGrindedAtTime;

        public CoffeeGrinderService(NonGroundedCoffeeTank nonGroundedCoffeeTank, CoffeeTank coffeeTank, int coffeeAmountGrindedAtTime)
        {
            _nonGroundedCoffeeTank = nonGroundedCoffeeTank;
            _coffeeTank = coffeeTank;
            _coffeeAmountGrindedAtTime = coffeeAmountGrindedAtTime;
        }

        public void ExecuteService()
        {
            if (_nonGroundedCoffeeTank.CheckIfEnough(_coffeeAmountGrindedAtTime))
            {
                if (_coffeeTank.CheckIfItHasAPlace(_coffeeAmountGrindedAtTime)){
                    GrindCoffee();
                    _coffeeTank.WriteCurrentTankState();
                    _nonGroundedCoffeeTank.WriteCurrentTankState();
                }
                else
                {
                    NotEnoughError notEnoughError = new NotEnoughError("Place for coffee", _coffeeTank.CurrentEmptySpace, _coffeeAmountGrindedAtTime);
                }
            }
            else
            {
                NotEnoughError notEnoughError = new NotEnoughError("NonGrounded coffee", _nonGroundedCoffeeTank.CurrentVolume, _coffeeAmountGrindedAtTime);
            }

        }

        private void GrindCoffee()
        {
            _nonGroundedCoffeeTank.Get(_coffeeAmountGrindedAtTime);
            _coffeeTank.Add(_coffeeAmountGrindedAtTime);
        }

        public string GetServicePurpose() => "Grind Coffee";
    }
}

