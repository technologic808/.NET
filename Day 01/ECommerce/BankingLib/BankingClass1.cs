using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    public class Account
    {

        private double _balance;

        public double Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            }
        }

        public Boolean withdraw(double amount) {
            if (_balance >= amount){
                Balance -= amount;
                return true;
            }
            return false;
            
        }

        public Boolean deposit(double amount)
        {
            if (amount > 0) {
                _balance += amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Account Balance: " + Balance;
        }
    }
}
