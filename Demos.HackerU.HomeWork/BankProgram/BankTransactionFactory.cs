using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BankProgram
{
    public static class BankTransactionFactory
    {
        public static DepositTransaction CreateDepositTransaction()
        {
            return new DepositTransaction();
        }
        public static WithdrawTransaction CreateWithdrawTransaction()
        {
            return new WithdrawTransaction();
        }
    }
}
