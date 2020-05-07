using System;
using System.Collections.Generic;
using System.Text;

namespace clenkasoft.DesignPatterns.Factory
{
    ///// <summary>
    ///// We could have used switch to create our vehicles, but that would bring too much logic
    ///// /// </summary>
    //public class Vehicle
    //{
    //    private readonly Dictionary<VehicleType, VehicleFactory> _factories;

    //    public Vehicle()
    //    {
    //        _factories = new Dictionary<VehicleType, VehicleFactory>
    //        {
    //            { VehicleType.personal, new PersonalCarFactory() },
    //            { VehicleType.truck, new TruckFactory() },
    //            { VehicleType.trailer, new TrailerFactory() },
    //        };
    //    }
    //}

    /// <summary>
    /// We could have used switch to create our vehicles, but that would bring too much logic
    /// Above we are doing too much. Let's use reflection
    /// </summary>
    public class Vehicle
    {
        private readonly Dictionary<VehicleTypes, VehicleFactory> _factories;

        public Vehicle()
        {
            _factories = new Dictionary<VehicleTypes, VehicleFactory>();
            foreach(VehicleTypes vehicleType in Enum.GetValues(typeof(VehicleTypes)))
            {
                var x = Enum.GetName(typeof(VehicleTypes), vehicleType);

                var factory = (VehicleFactory)Activator.CreateInstance(Type.GetType("clenkasoft.DesignPatterns.Factory." + Enum.GetName(typeof(VehicleTypes),vehicleType) + "Factory"));
                _factories.Add(vehicleType, factory);
            }
        }

        /// <summary>
        /// Creation Method
        /// </summary>
        /// <param name="vehicleType"></param>
        /// <param name="wheelCount"></param>
        /// <returns></returns>
        public IVehicle ExecuteCreation(VehicleTypes vehicleType, int wheelCount) => _factories[vehicleType].create(wheelCount);
    }
}
