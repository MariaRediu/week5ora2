using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
   public class DepositAccount:Account,IDrawable
    {
        public DepositAccount(Customer client,decimal balance,decimal interesRate) : base(client, balance, interesRate)
        {

        }
        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                Console.WriteLine("You cannot withdraw more than the balance of the account");
            }
            this.Balance -= amount;
        }
        public override decimal CalculateInterest(int months)
        {
            if (this.Balance >= 1000.0m)
            {
                return months * ((this.InteresRate / 100.0m) * this.Balance);
            }
            else
                return 0.0m;
        }

        public override string ToString()
        {
            return String.Format("DEPOSIT - {0} - {1:C}", this.Client.Name, this.Balance);
        }

    }
}
