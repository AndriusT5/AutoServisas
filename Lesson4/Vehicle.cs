using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Vehicle
    {
        public string Make;
        public string Model;
        public int MadeYear;
        public string Color;
        public bool IsBroken;
        public bool TechValid;

        public void StartEngine()
        {
            Console.WriteLine($"{Make} Engine started was started;");
        }
    }
}
