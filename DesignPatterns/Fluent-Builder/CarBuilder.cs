using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class CarBuilder : IBuilder<Car>
    {
        private Car _car = new Car();

        public CarBuilder  AddWarrinty(int years)
        {
            _car.WarrintyInYears = years;
            return this;
        }

        public CarBuilder Add4WheelDrive()
        {
            _car.Has4WheelDrive = true;
            return this;
        }

        public CarBuilder AddConvertable()
        {
            _car.IsConvertable = true;
            return this;
        }

        public CarBuilder AddOwner(string owner)
        {
            _car.Owner = owner;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}
