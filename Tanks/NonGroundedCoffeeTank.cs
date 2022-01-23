using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Tanks
{
    class NonGroundedCoffeeTank : Tank
    {
        public override string Name => "Non Grounded Coffee Tank";

        public NonGroundedCoffeeTank(int maxVolume) : this(maxVolume, maxVolume)
        {

        }

        public NonGroundedCoffeeTank() : this((int)TankVolume.Medium, (int)TankVolume.Medium)
        {

        }

        public NonGroundedCoffeeTank(int maxVolume, int currentVolume) : base(maxVolume, currentVolume)
        {
        } 
    }
}
