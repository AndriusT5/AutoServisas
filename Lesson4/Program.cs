using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Cars
            Car car1 = new Car();
            car1.Make = "Volvo";
            car1.Model = "S60";
            car1.MadeYear = 2011;
            car1.Color = "Black";
            car1.Id = 1;
            car1.FuelType = FuelType.Petrol;

            Car car2 = new Car() { Make = "BMW", Model = "530", Color = "White", Id = 2, MadeYear = 2017, FuelType = FuelType.Gas };

            Car car3 = new Car()
            {
                Make = "VW",
                Model = "Golf",
                MadeYear = 2020,
                Id = 3,
                Color = "Red",
                FuelType = FuelType.Diesel
            };

            Car car4 = new Car() { Make = "Opel", Model = "Astra", Color = "White", Id = 4, MadeYear = 2011 };
            Car car5 = new Car() { Make = "Nissan", Model = "Primera", Color = "Blue", Id = 5, MadeYear = 2000 };
            Car car6 = new Car() { Make = "BMW", Model = "730", Color = "Brown", Id = 6, MadeYear = 2020 };

            car1.Color = "Green";
            #endregion

            Person person1 = new Person() { Name = "Jonas", Surname = "Jonaitis", Age = 33 };
            person1.BuyCar(car2);
            person1.BuyCar(car3);

            Person person2 = new Person() { Name = "Antanas", Surname = "Antanaitis", Age = 24 };
            person2.BuyCar(car1);
            person2.BuyCar(car6);
            //car1.StartEngine();

            AutoService melgaAutoservice = new AutoService() { Address = "Ulonu g. 2, Vilnius", Name = "Melga", Id = 1, Capacity = 4 };
            melgaAutoservice.RepairCar(person2.OwnedCars.ElementAt(0));
            melgaAutoservice.RepairCar(person2.OwnedCars.Where(c => c.Make == "BMW" && c.Model == "730").First()); //LINQ
            melgaAutoservice.RepairCar(car5);
            melgaAutoservice.RepairCar(car3);
            melgaAutoservice.RepairCar(car2);

            melgaAutoservice.PrintRepairableCars();
            melgaAutoservice.RepairCar(car4);


            Console.ReadLine();
        }
    }
}
