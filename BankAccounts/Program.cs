using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = LoadAccounts();
            Console.WriteLine(bank);
        }

        private static Bank LoadAccounts()
        {
            Bank bank = new Bank();

            bank.AddAccount(new MortgageAccount(new Individual("Individual Company"), 50000.0m, 25));
            bank.AddAccount(new DepositAccount(new Company("Company"), 7500.0m, 12));
            bank.AddAccount(new LoanAccount(new Company("'LoanCompany"), 175000.0m, 22));
            bank.AddAccount(new MortgageAccount(new Individual("Mortgage Company"), 30500.0m, 50));
            bank.AddAccount(new DepositAccount(new Company("My Company"), 12450.0m, 13));
            bank.AddAccount(new LoanAccount(new Individual("AnotherLoan"), 129.0m, 2));

            return bank;
        }
    }
}
