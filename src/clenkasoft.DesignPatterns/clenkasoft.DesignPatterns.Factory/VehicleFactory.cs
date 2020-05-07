using System;
using System.Collections.Generic;
using System.Text;

namespace clenkasoft.DesignPatterns.Factory
{
    /// <summary>
    /// The factory is just an abstract class to be overriden by concrete classes. Provide methods they
    /// can override to achieve their aims
    /// </summary>
    public abstract class VehicleFactory
    {
        //Let concrete classes override the create method to do their own creation
        public abstract IVehicle create(int wheelCount);
    }
}
