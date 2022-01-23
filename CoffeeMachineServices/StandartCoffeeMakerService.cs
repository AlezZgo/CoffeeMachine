using System;
using System.Collections.Generic;
using System.Text;
using CoffeeMachineApp.interfaces;
using CoffeeMachineApp.Recipes;
using CoffeeMachineApp.Tanks;
using CoffeeMachineApp.Exceptions;
using CoffeeMachineApp.Errors;


namespace CoffeeMachineApp.CoffeeMachineServices
{
    class StandartCoffeeMakerService : IService
    {
        private CoffeeRecipe _coffeeRecipe;
        private CoffeeTank _coffeeTank;
        private WaterTank _waterTank;
        private RefuseTank _refuseTank;

        public StandartCoffeeMakerService(CoffeeRecipe coffeeRecipe, CoffeeTank coffeeTank, WaterTank waterTank, RefuseTank refuseTank)
        {
            _coffeeRecipe = coffeeRecipe;
            _coffeeTank = coffeeTank;
            _waterTank = waterTank;
            _refuseTank = refuseTank; 
        }

        public string GetServicePurpose() => $"Make {_coffeeRecipe.Name}";

        public virtual void ExecuteService()
        {
            if (CheckAllTanks())
            {
                StartMakingCoffeeProcess();
                Console.WriteLine($"{_coffeeRecipe.Name} is ready!");
            }
        }

        public virtual bool CheckAllTanks()
        {
            if (!_coffeeTank.CheckIfEnough(_coffeeRecipe.CoffeeAmount))
            {
                NotEnoughError notEnoughError = new NotEnoughError("Coffee",_coffeeTank.CurrentVolume,_coffeeRecipe.CoffeeAmount);
                return false;
            }

            if (!_waterTank.CheckIfEnough(_coffeeRecipe.WaterAmount))
            {
                NotEnoughError notEnoughError = new NotEnoughError("Water", _waterTank.CurrentVolume, _coffeeRecipe.WaterAmount);
                return false;
            }
            if (!_refuseTank.CheckIfItHasAPlace(_coffeeRecipe.CoffeeAmount))
            {
                NotEnoughError notEnoughError = new NotEnoughError("Place in Refuse tank", _refuseTank.CurrentVolume, _coffeeRecipe.CoffeeAmount);
                return false;
            }
            return true;
                
        }

        public virtual void StartMakingCoffeeProcess()
        {
            _coffeeTank.Get(_coffeeRecipe.CoffeeAmount);
            _waterTank.Get(_coffeeRecipe.WaterAmount);
            _refuseTank.Add(_coffeeRecipe.CoffeeAmount);
        }

    }
}
