using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSection_2.Classes
{
    public class BankAccount
    {
        private float balance;
        public string owner;
               
        public BankAccount(float balance, string owner)
        {
            this.balance = balance;
            this.owner = owner;
        }
        public float AddBalance(float balanceToBeAdded) 
        {
            return balance + balanceToBeAdded;
        }
    }
}
