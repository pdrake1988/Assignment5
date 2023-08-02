using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Bank
{
    public class BankAccount
    {
        public BankAccount(string accountNumber, string accountName, string accountAddress)
        {
            this.AccountNumber = accountNumber;
            this.AccountName = accountName;
            this.AccountAddress = accountAddress;
        }

        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountAddress { get; set; }
    }
}
