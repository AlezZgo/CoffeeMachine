using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Tanks
{
    class MilkTank : Tank
    {
        public override string Name => "Milky Tank";

        public MilkTank() : this((int)TankVolume.Medium, (int)TankVolume.Medium)
        {
        }

        public MilkTank(int maxVolume) : this(maxVolume, maxVolume)
        {
        }

        public MilkTank(int maxVolume, int currentVolume) : base(maxVolume, currentVolume)
        {
        }


    }
}
