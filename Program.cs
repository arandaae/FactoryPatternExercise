using System;

namespace FactoryPatternExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the type of vehicle you would like.");
            Console.WriteLine("Enter a 1 for a motorcycle.");
            Console.WriteLine("Enter a 2 for a car");
            
            var vehicleType = Convert.ToInt32(Console.ReadLine());
            IVehicle newVehicle = VehicleFactory.GetVehicle(vehicleType);

            newVehicle.Drive();
        }
    }
}
