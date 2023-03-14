using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CreateBankAccount_Assignment
{
    internal class Account
    {
        string id;
        decimal balance;
        private static Random random = new Random();
        public Account(string fName, string lName, decimal amount) 
        {
           id = random.Next(100000, 100000).ToString();
           CustomerName = $"{fName} {lName}";
           balance = balance;
           
        }

        public decimal Balance { get => balance; }
        public string Id { get => id; }
        public string CustomerName { get => CustomerName; set => CustomerName = value; }
        
        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                MessageBox.Show("Your Deposit should have to be Positive!");
            }
            balance += amount;  
        }
        public virtual void Withdrow(decimal amount)
        {
            if(amount <= 0)
            {
                MessageBox.Show("Withdrow amount should have to be greater than 0");
            }
            if(amount > balance)
            {
                MessageBox.Show("You have Insufficient balance!");
            }
            balance -= amount;
        }
        public override string ToString()
        {
            return $"{Id}-{GetType().Name}-{CustomerName}- balance: {Balance.ToString("c")}";
        }
    }
}
