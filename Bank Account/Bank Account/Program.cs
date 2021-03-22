using System;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Mr. Rahman", "123456", 100000);
            Account a2 = new Account("Mr. Rahim", "123457", 100000);

            a1.Withdraw(40000);
            a1.Deposit(15000);
            a1.Transfer(a2, 60000);
            a2.Transfer(a1, 50000);

            Console.WriteLine("\n");
            a1.ShowInfo();
            Console.WriteLine("\n");
            a2.ShowInfo();
            Console.ReadLine();
        }
    }
}