using System.Reflection;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Testing Printer Class ===\n");

            Printer printer = new Printer();

            printer.Print("Hello World!");
            printer.Print(42);
            printer.Print("Repeating message", 5);

            Console.WriteLine("\n=== Testing Teacher Inheritance ===\n");

            // Create NepaliTeacher object
            NepaliTeacher nepaliTeacher = new NepaliTeacher();
            nepaliTeacher.Name = "Ram Bahadur";

            Console.WriteLine($"Teacher Name: {nepaliTeacher.Name}");
            nepaliTeacher.Teaching();      // Overridden method
            nepaliTeacher.SalaryInfo();    // Inherited final method

            Console.WriteLine();

            // Create EnglishTeacher object
            EnglishTeacher englishTeacher = new EnglishTeacher();
            englishTeacher.Name = "John Smith";

            Console.WriteLine($"Teacher Name: {englishTeacher.Name}");
            englishTeacher.Teaching();     // Uses base class implementation
            englishTeacher.SalaryInfo();   // Inherited final method

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
