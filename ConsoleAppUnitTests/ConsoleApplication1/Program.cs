using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcount acc = new BankAcount(3333m);
            Console.WriteLine(acc.Amount);
        }
    }
}
