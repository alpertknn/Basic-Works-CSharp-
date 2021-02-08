using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Money
    {
        public string currency;
        public int balance;
        public Money()
        {
            balance = 0;
            currency = " ";
        }
        public Money(int bal,string cur)
        {
            balance = bal;
            currency = cur;
        }
        public int depositMoney(int amount)
        {
            balance += amount;

            return balance;
        }
        public int withdrawMoney(int amount)
        {
           balance -= amount;

            return balance;
        }
        public string show()
        {
            return balance + " " + currency;

        }

    }

}

