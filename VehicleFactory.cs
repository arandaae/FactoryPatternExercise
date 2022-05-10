using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int vehicleType)
        {
            return vehicleType switch
            {
                1 => new Motorcycle(),
                2 => new Car(),
                _ => new DefaultCar(),
            };
        }
    }
}
