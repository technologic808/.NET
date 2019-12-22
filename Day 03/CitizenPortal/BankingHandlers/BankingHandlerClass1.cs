using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingHandlers
{
    public class AccountListener
    {
        public static void SendEmail() {
            Console.WriteLine("Your account seems to have low balance. Please fulfill minimum balance requirements.");
        }

        public static void ChangeInterestRate() {
            Console.WriteLine("Your interest rate has been increased to 8% from 4% !");
        }

        public static void TrackAccount() {
            Console.WriteLine("Your account has been put on tracking");
        }

    }
}
