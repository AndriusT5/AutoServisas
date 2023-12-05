using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public enum FuelType { Petrol, Diesel, Gas, Hybrid }
    public class Car: Vehicle
    {
        public int Id;
        private string Vin;
        public FuelType FuelType;
      
    }
}
