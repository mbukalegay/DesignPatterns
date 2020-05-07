using System;
using System.Collections.Generic;
using System.Text;

namespace clenkasoft.DesignPatterns.Factory
{
    public class PersonalCarFactory : VehicleFactory
    {
        // You must override all methods provided by the abstract class
        //public override IVehicle create(int wheelCount)
        //{
        //    return new PersonalCar(wheelCount);
        //}

        public override IVehicle create(int wheelCount) => new PersonalCar(wheelCount);

    }
}
