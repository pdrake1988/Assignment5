using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Bank
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(
            string accountName,
            string accountNumber,
            string accountAddress,
            double balance
        )
            : base(accountName, accountNumber, accountAddress)
        {
            this.Balance = balance;
        }

        public double Balance { get; set; }
    }
}
