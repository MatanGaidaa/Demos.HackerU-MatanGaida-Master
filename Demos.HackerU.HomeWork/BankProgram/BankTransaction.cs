using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BankProgram
{
    public abstract class BankTransaction
    {
        public abstract void ExecuteTransaction(BankAccount account, decimal amount);

    }
}
