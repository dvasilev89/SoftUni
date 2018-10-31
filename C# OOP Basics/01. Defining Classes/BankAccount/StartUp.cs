using System;

namespace BankAccount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            Console.WriteLine(bankAccount.Balance);
        }
    }
}
