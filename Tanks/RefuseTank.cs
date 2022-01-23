using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineApp.Tanks
{
    class RefuseTank : Tank
    {
        public override string Name => "Refuse Tank";

        public RefuseTank() : this((int)TankVolume.Medium, 0)
        {
        }

        public RefuseTank(int maxVolume) : this(maxVolume, 0)
        {
        }

        public RefuseTank(int maxVolume, int currentVolume) : base(maxVolume, currentVolume)
        {
        }
    }
}
