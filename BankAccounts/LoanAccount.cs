using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
   public class LoanAccount :Account
    {
        public LoanAccount(Customer client, decimal balance, decimal interesRate) : base(client, balance, interesRate)
        {

        }
       public override decimal CalculateInterest(int months)
        {
            if (this.Client is Individual)
            {
                months = Math.Max(0, months - 3);
            }
            else
            {
                months = Math.Max(0, months - 2);
            }

            return months * ((this.InteresRate / 100.0m) * this.Balance);
        }

      
         public override string ToString()
        {
            return String.Format("LOAN - {0} - {1:C}", this.Client.Name, this.Balance);
        }    
    }
}
