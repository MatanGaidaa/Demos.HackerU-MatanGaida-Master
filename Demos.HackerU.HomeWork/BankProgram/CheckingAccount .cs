using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BankProgram
{
    public class CheckingAccount : BankAccount
    {
        public decimal MonthlyFee { get; set; }
        public decimal MinimumBalance { get; set; }

        public CheckingAccount() : base()
        {
            MonthlyFee = 0;
            MinimumBalance = 0;
        }

        public CheckingAccount(decimal monthlyFee, decimal minimumBalance, string accountNumber, string accountType, decimal balance, string ownerName)
            : base(accountNumber, accountType, balance, ownerName)
        {
            MonthlyFee = monthlyFee;
            MinimumBalance = minimumBalance;
        }
    }
}
