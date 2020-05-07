using System;
using System.Collections.Generic;
using System.Text;

namespace clenkasoft.DesignPatterns.Factory
{
    public class Trailer : IVehicle
    {
        private readonly int _wheelCount ;

        public Trailer(int wheelCount)
        {
            _wheelCount = wheelCount;
        }

        public void getNumberOfWheels()
        {
            Console.WriteLine($"A trailer has {_wheelCount} wheels");
        }
    }
}
