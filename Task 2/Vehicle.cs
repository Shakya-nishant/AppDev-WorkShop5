using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping...");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

}
