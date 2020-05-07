using System;
using System.Collections.Generic;
using System.Text;

namespace clenkasoft.DesignPatterns.Factory
{
    public class Truck : IVehicle
    {
        private readonly int _wheelCount;

        public Truck(int wheelCount)
        {
            _wheelCount = wheelCount;
        }

        public void getNumberOfWheels()
        {
            Console.WriteLine($"A truck has {_wheelCount} wheels");
        }
    }
}
