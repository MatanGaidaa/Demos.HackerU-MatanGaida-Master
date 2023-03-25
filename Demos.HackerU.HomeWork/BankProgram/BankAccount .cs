using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BankProgram
{
    public class BankAccount : ITransferable
    {
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public string OwnerName { get; set; }

        public BankAccount()
        {
            AccountNumber = string.Empty;
            AccountType = string.Empty;
            Balance = 0;
            OwnerName = string.Empty;
        }

        public BankAccount(string accountNumber, string accountType, decimal balance, string ownerName)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            Balance = balance;
            OwnerName = ownerName;
        }

        public void Transfer(BankAccount source, BankAccount target, decimal amount)
        {
            if (source.Balance < amount)
            {
                Console.WriteLine("Insufficient funds");
            }

            else
            {
                BankTransaction withdrawTransaction = BankTransactionFactory.CreateWithdrawTransaction();
                withdrawTransaction.ExecuteTransaction(source, amount);

                BankTransaction depositTransaction = BankTransactionFactory.CreateDepositTransaction();
                depositTransaction.ExecuteTransaction(target, amount);

            }
        }
    }
}
