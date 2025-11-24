using System.Reflection;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printer object and method overloading
            Printer printer = new Printer();
            printer.Print("Hello C#");
            printer.Print(123);
            printer.Print("Overloading Example", 3);

            Console.WriteLine();

            // Teacher objects and inheritance
            NepaliTeacher nepali = new NepaliTeacher();
            nepali.Name = "Ram";
            nepali.Teaching();
            nepali.SalaryInfo();

            Console.WriteLine();

            EnglishTeacher english = new EnglishTeacher();
            english.Name = "John";
            english.Teaching();   // Uses base class method
            english.SalaryInfo();
        }
    }

}
