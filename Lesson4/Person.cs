using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Person
    {
        int PesonalCode;
        public string Name;
        public string Surname;
        public int Age;
        public List<Car> OwnedCars = new List<Car>();
        public List<Bike> OwnedBikes = new List<Bike>();

        public void BuyCar(Car car)
        {
            OwnedCars.Add(car);
            Console.WriteLine($"Congrats with new car {car.Make}");
        }

        public void BuyBike(Bike bike)
        {
            OwnedBikes.Add(bike);
            Console.WriteLine($"Congrats with new car {bike.Make}");
        }
    }
}
