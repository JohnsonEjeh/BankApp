using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    internal class SavingsAccount : Account
    {
        private const double TRANSACTION_FEE = 5;
        public double Interest { get; set; }

        public SavingsAccount(int number, string name, double balance, double interest) : base(number, name, balance)
        {
            Interest = interest;
        }

        public override void Deposit(double amount) 
        { 
            Balance += amount;
            Balance -= TRANSACTION_FEE;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            Balance -= TRANSACTION_FEE;
        }
    }
}
