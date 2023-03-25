using Demos.HackerU.HomeWork.BankProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork
{
    public class BankOOP
    {

        public static void Run()
        {
            SavingsAccount savingsAccount = new SavingsAccount(0.01m, "1234", "savings", 1000m, "John Doe");

            CheckingAccount checkingAccount = new CheckingAccount(5m, 0.01m, "654321", "checking", 500m, "Jane Smith");

            savingsAccount.Transfer(savingsAccount, checkingAccount, 500m);

            Console.WriteLine($"Savings account balance: {savingsAccount.Balance}");
            Console.WriteLine($"Checking account balance: {checkingAccount.Balance}");
        }
    }
}
