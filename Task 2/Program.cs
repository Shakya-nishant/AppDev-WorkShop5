namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Brand = "Toyota",
                Speed = 180,
                Seats = 5
            };

            Motorcycle bike = new Motorcycle()
            {
                Brand = "Yamaha",
                Speed = 120,
                HasCarrier = true
            };

            // Demonstrating code reusability (using base class methods)
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine();

            bike.Start();
            bike.DisplayInfo();
            bike.Stop();
        }
    }

}
