using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Seats: {Seats}");
        }
    }

}
