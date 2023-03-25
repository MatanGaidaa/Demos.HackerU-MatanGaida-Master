using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BankProgram
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount() : base()
        {
            InterestRate = 0;
        }

        public SavingsAccount(decimal interestRate, string accountNumber, string accountType, decimal balance, string ownerName)
            : base(accountNumber, accountType, balance, ownerName)
        {
            InterestRate = interestRate;
        }
    }
}
