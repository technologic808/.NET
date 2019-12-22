using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    // Create delegate to handle events related to the account
    public delegate void AccountEventHandler();
    public class Account {

        // Create events related to the account using AccountEventHandler delegate.
        public event AccountEventHandler UnderBalance;
        public event AccountEventHandler OverBalance;

        private double _balance;

        public Account() {

        }

        public Account(double initialBalance) {
            Balance = initialBalance;
        }

        public double Balance {
            get {
                return _balance;
            }

            set {
                _balance = value;
            }
        }

        public Boolean Withdraw(double amount) {
            if (_balance >= amount) {
                Balance -= amount;
                Monitor();
                return true;
            }
            return false;

        }

        public Boolean Deposit(double amount) {
            if (amount > 0) {
                _balance += amount;
                Monitor();
                return true;
            }
            return false;
        }

        public override string ToString() {
            return "Account Balance: " + Balance;
        }

        // Create Monitor Function to raise events
        void Monitor() {
            if (Balance < 2500) {
                // Raise an event (which will be dealt with by someone else)
                UnderBalance();
            }
            if (Balance > 100000) {
                // Raise an event (which will be dealt with by someone else)
                OverBalance();
            }

        }
    }
}
