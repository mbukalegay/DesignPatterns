using System;
using System.Collections.Generic;
using System.Text;

namespace clenkasoft.DesignPatterns.Factory
{
    public class TrailerFactory : VehicleFactory
    {
        // You must override all methods provided by the abstract class
        public override IVehicle create(int wheelCount) => new Trailer(wheelCount);
    }
}
