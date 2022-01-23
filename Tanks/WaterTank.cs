using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Tanks
{
    class WaterTank : Tank
    {
        public override string Name => "Water Tank";

        public WaterTank() : this((int)TankVolume.Medium, (int)TankVolume.Medium)
        {
        }

        public WaterTank(int maxVolume) : this(maxVolume, maxVolume)
        {
        }

        public WaterTank(int maxVolume, int currentVolume) : base(maxVolume, currentVolume)
        {
            
        }

        
    }
}
