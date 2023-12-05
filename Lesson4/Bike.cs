using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Bike: Vehicle
    {
        public int WheelCount;
        public int SeatsCount;

        public void DriveOnOneWheel()
        {
            Console.WriteLine("Riding on one wheel...");
        }
    }
}
