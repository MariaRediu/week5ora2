﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    interface IDepositable
    {
        void Deposit(decimal amount);
    }
}
