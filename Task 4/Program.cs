namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bike bike = new Bike();

            Console.WriteLine("Car Object:");
            car.Display();
            car.StartEngine();
            car.StopEngine();

            Console.WriteLine("-------------------------");

            Console.WriteLine("Bike Object:");
            bike.Display();
            bike.StartEngine();
            bike.StopEngine();

            Console.ReadLine();
        }
    }

}
