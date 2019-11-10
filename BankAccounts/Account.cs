using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Account: IDepositable
    {
        public Customer customer;
        public Customer Name { get; set; }
        public decimal Balance { get; set; }
        public  decimal  InteresRate { get; set; }

        public Account(Customer name,decimal balance,decimal rate)
        {
            this.Name = name;
            this.Balance = balance;
            this.InteresRate = rate;
           
            
        }
        public Customer Client
        {
            get { return this.customer; }
            set
            {
                this.customer = value;
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Please re - enter the amount");
            }
            {
                this.Balance += amount;
            }
        }
        public abstract decimal CalculateInterest(int months);
       

    }
}
