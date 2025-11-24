using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Teacher
    {
        public string Name { get; set; }

        // Virtual method that can be overridden
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Final method - cannot be overridden
        public void SalaryInfo()
        {
            Console.WriteLine("Salary is paid monthly based on government scale.");
        }
    }
}
