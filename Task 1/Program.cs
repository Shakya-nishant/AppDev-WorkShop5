namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123456789", 5000);

            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Initial Balance: " + account.Balance);

            account.Deposit(1500);
            account.Withdraw(1000);

            Console.WriteLine("Remaining Balance: " + account.Balance);
        }
    }

}
