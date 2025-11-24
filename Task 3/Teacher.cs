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

        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        public sealed void SalaryInfo()
        {
            Console.WriteLine("Teacher salary information cannot be overridden.");
        }
    }


}
