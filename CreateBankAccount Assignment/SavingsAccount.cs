using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBankAccount_Assignment
{
    internal class SavingsAccount : Account
    {
        private decimal interest;

        public SavingsAccount(string fName, string lName, decimal amount ,decimal interest) : base(fName, lName, amount)
        {
          Interest = interest;
        }
        public decimal Interest { get => interest; set => interest = value; }
        public void AddInterest()
        {
            decimal balance =+ Balance * Interest;
        }
        public override string ToString()
        {
            return base.ToString() + $"-Interset : {Interest}";
        }
    }
}
