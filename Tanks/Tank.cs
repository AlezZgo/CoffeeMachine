using System;

namespace CoffeeMachineApp.Tanks
{
    abstract class Tank
    {
        protected readonly int _maxVolume;
        protected int _currentVolume;

        public abstract string Name { get; }

        public int CurrentVolume { get => _currentVolume; }
        public int CurrentEmptySpace { get => _maxVolume - _currentVolume; }
        public int MaxVolume { get => _maxVolume; }

        public Tank(int maxVolume, int currentVolume)
        {
            _maxVolume = maxVolume;
            _currentVolume = currentVolume>maxVolume? maxVolume : currentVolume;
        }

        public bool CheckIfEnough(int amount) => _currentVolume >= amount;

        public bool CheckIfItHasAPlace(int amount) => _currentVolume + amount <= _maxVolume;

        public virtual void Fill() => _currentVolume = _maxVolume;  

        public virtual void MakeEmpty() => _currentVolume = 0;

        public void WriteCurrentTankState() => Console.WriteLine($"Current Volume of {Name} is {_currentVolume} / {_maxVolume}");

        public virtual void Add(int value)
        {
            _currentVolume += value;
            _currentVolume = _currentVolume > _maxVolume ? _maxVolume : _currentVolume;
        }

        public virtual void Get(int value)
        {
            _currentVolume -= value;
            _currentVolume = _currentVolume > _maxVolume ? _maxVolume : _currentVolume;
        }




    }
}
