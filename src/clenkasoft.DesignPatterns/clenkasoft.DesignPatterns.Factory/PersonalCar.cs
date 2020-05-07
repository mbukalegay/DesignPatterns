using System;
using System.Collections.Generic;
using System.Text;

namespace clenkasoft.DesignPatterns.Factory
{
    public class PersonalCar : IVehicle
    {
        private readonly int _wheelCount;

        public PersonalCar(int wheelCount)
        {
            _wheelCount = wheelCount;
        }

        public void getNumberOfWheels()
        {
            Console.WriteLine($"A personal car has {_wheelCount} wheels");
        }
    }
}
