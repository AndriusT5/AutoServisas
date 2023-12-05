using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class AutoService
    {
        public int Id;
        public string Name;
        public string Address;
        public int Capacity;
        private List<Car> RepearableCars = new List<Car>();

        public void RepairCar(Car car)
        {
            if (RepearableCars.Count < Capacity)
            {
                RepearableCars.Add(car);
                Console.WriteLine("Car is started repairing.");
            }
            else
            {
                Console.WriteLine("Sorry service is fully booked.");
            }

        }

        public void PrintRepairableCars()
        {
            foreach (var car in RepearableCars)
            {
                Console.WriteLine($"{car.Make} {car.Model} is in repair");
            }
        }
    }
}
