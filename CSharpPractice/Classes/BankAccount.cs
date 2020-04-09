using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Classes
{
    public class BankAccount
    {
        private double balance;
        public double Balance
        {
            get
            {
                if (balance < 1000000)
                {
                    return balance;
                }
                return 1000000;
            }
            protected set //only accessible in this class and any class that inherits functionality (protected is less private than the private modifier) (private means only this class)
            {
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                    balance = 0;
                }
            }
        }

        public BankAccount() //Constructor
        {
            Balance = 100;
        }
        public BankAccount( double initialBalance) //overload constructor
        {
            Balance = initialBalance;
        }

        public virtual double AddToBalance(double balanceToBeAdded) //virtual marks method as overridable
        {
            Balance += balanceToBeAdded;
            return Balance;
        }
    }
    public class ChildBankAccount : BankAccount //ChildBankAccount class inherets all functionality from the BankAccount class
    {
        public ChildBankAccount()
        {
            Balance = 10;
        }
        public override double AddToBalance(double balanceToBeAdded) //have to write override to actually override
        {
            if (balanceToBeAdded > 1000)
            {
                balanceToBeAdded = 1000;
            }
            if (balanceToBeAdded < -1000)
            {
                balanceToBeAdded = -1000;
            }
            return base.AddToBalance(balanceToBeAdded);
        }
    }
}
