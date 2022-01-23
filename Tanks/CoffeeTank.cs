using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Tanks
{
    class CoffeeTank : Tank
    {
        public override string Name => "Coffee Tank";

        public CoffeeTank() : this((int)TankVolume.Medium, (int)TankVolume.Medium)
        {
        }

        public CoffeeTank(int maxVolume) : this(maxVolume, maxVolume)
        {
        }

        public CoffeeTank(int maxVolume, int currentVolume) : base(maxVolume, currentVolume)
        {
        }

        
    }
}
