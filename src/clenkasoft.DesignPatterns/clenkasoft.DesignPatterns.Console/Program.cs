using clenkasoft.DesignPatterns.Factory;
using System;

namespace clenkasoft.DesignPatterns.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Starting Factory Pattern Execution");

            System.Console.WriteLine("Create personal car");
            var car = new Vehicle().ExecuteCreation(VehicleTypes.PersonalCar,4);
            car.getNumberOfWheels();
            System.Console.WriteLine("--------------------------------------------");

            System.Console.WriteLine("Create truck");
            var truck = new Vehicle().ExecuteCreation(VehicleTypes.Truck,6);
            truck.getNumberOfWheels();
            System.Console.WriteLine("--------------------------------------------");

            System.Console.WriteLine("Create trailer");
            var trailer = new Vehicle().ExecuteCreation(VehicleTypes.Trailer, 16);            
            trailer.getNumberOfWheels();
            System.Console.WriteLine("--------------------------------------------");

            System.Console.WriteLine("Ending Factory Pattern Execution");
            System.Console.ReadKey();
        }
    }
}
