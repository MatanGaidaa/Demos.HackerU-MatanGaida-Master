using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BankProgram
{
    public interface ITransferable
    {
        void Transfer(BankAccount source, BankAccount target, decimal amount);
    }
}
