using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CreateBankAccount_Assignment
{
    internal class CheckingAccount : Account
    {

        private decimal overdraftFee;
        public CheckingAccount(string fName, string lName, decimal balance,decimal overdraftFee) : base(fName, lName, balance)
        {
            overdraftFee = overdraftFee;
        }
        public decimal OverdraftFee { get => overdraftFee; set => overdraftFee = value; }
        public override void Withdrow(decimal amount)
        {
           if(amount < 0)
           {
               MessageBox.Show("your Withdrow amount should be Positive!");
           }
           if(amount > Balance)
           {
               decimal balance =- OverdraftFee;
           }
           else
           {
                decimal balance =- amount;
           }
           
        }

        public override string ToString()
        {
            return base.ToString() + $"-overdraftFee : {OverdraftFee}";
        }

    }
}
