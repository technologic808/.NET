using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;
using BankingHandlers;
using Government;

namespace Portal {
    class Program {
        static void Main(string[] args) {

            // Create an account
            Account S1 = new Account(15000);

            Console.WriteLine(S1);

            // Create an AccountEventHandler delegate pointing to SendEmail function in AccountListener and attach it to Underbalance event
            S1.UnderBalance += new AccountEventHandler(AccountListener.SendEmail);

            // Create multicast AccountEventHandler delegates pointing to relevant functions and attach it to OverBalance event
            S1.OverBalance += 
                new AccountEventHandler(AccountListener.ChangeInterestRate) + 
                new AccountEventHandler(AccountListener.TrackAccount) + 
                new AccountEventHandler(Republican.CapitalGainsTax) + 
                new AccountEventHandler(Republican.IncomeTax);

            S1.Deposit(90000);
            S1.Withdraw(103000);

            Console.ReadLine();

        }
    }
}
