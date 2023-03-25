using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BankProgram
{
    public class DepositTransaction : BankTransaction
    {
        public override void ExecuteTransaction(BankAccount account, decimal amount)
        {
            account.Balance += amount;
        }
    }
}
