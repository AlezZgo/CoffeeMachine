using System;
using System.Collections.Generic;
using System.Text;
using CoffeeMachineApp.interfaces;
using CoffeeMachineApp.Recipes;
using CoffeeMachineApp.Tanks;
using CoffeeMachineApp.Errors;

namespace CoffeeMachineApp.CoffeeMachineServices
{
    class MilkyCoffeeMakerService : StandartCoffeeMakerService
    {
        private const int _minMilkForRecipe = 0;
        private const int _maxMilkForRecipe = 100;

        private MilkyCoffeeRecipe _milkyCoffeeRecipe;
        private MilkTank _milkyTank;

        public MilkyCoffeeMakerService(MilkyCoffeeRecipe coffeeRecipe, CoffeeTank coffeeTank, WaterTank waterTank, RefuseTank refuseTank, MilkTank milkyTank)
            : base(coffeeRecipe, coffeeTank, waterTank, refuseTank)
        {
            _milkyTank = milkyTank;
            _milkyCoffeeRecipe = coffeeRecipe;
        }

        public override void ExecuteService()
        {
            Console.WriteLine("Enter milk value from 0 to 100");
            int inputedValueOfMilk = 0;
            if (int.TryParse(Console.ReadLine(), out inputedValueOfMilk) && CheckIfInputedValueInBounds(inputedValueOfMilk))
            {
                _milkyCoffeeRecipe.MilkAmount = inputedValueOfMilk;
                base.ExecuteService();
            }
            else
            {
                IncorrectInputError incorrectInputError = new IncorrectInputError(inputedValueOfMilk, _minMilkForRecipe, _maxMilkForRecipe);
                Console.WriteLine("Operation rejected");
            }
        }

        private bool CheckIfInputedValueInBounds(int value) => value >= _minMilkForRecipe && value <= _maxMilkForRecipe;

        public override bool CheckAllTanks()
        {
            if (!_milkyTank.CheckIfEnough(_milkyCoffeeRecipe.MilkAmount))
            {
                NotEnoughError notEnoughError = new NotEnoughError("Milk", _milkyTank.CurrentVolume, _milkyCoffeeRecipe.CoffeeAmount);
                return false;
            }
            return base.CheckAllTanks();
        }

        public override void StartMakingCoffeeProcess()
        {
            base.StartMakingCoffeeProcess();
            _milkyTank.Get(_milkyCoffeeRecipe.MilkAmount);
        }



    }
}
