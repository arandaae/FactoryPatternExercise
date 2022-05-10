using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    class DefaultCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Default Car.");
        }
    }
}
