using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02___The_Essentials
{
    public class Account
    {
        private float balance;
        public void deposit(float amount)
        {
            if(amount > 0)
                this.balance += amount;
        }
        public void withdraw(float amount)
        {
            if (amount > 0)
                this.balance -= amount;
        }
        public void setBalance(float balance)
        {
            if (balance > 0)
                this.balance = balance;
        }
        public float getBalance()
        {
            return balance;
        }
    }
}
