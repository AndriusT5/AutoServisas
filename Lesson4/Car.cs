using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public enum FuelType { Petrol, Diesel, Gas, Hybrid }
    public class Car: Vehicle, ICar
    {
        public int Id;
        private string Vin;
        public FuelType FuelType;

        public Car(string make, string model, string vin)
        {
            Make = make;
            Model = model;

            if (vin.Length == 8)
            {
                Vin = vin;
            }
            else
            {
                Vin = "NENUSTATYTA";
            }
           
        }

        public Car()
        {

        }

        public void TurnEngine()
        {
            Console.WriteLine("Engine is running");
        }
    }
}
