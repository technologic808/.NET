using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var question in QuestionManager.GetQuestions())
            {
                Console.WriteLine(question + "\n");
                
            }
          
            Console.ReadLine();
        }
    }
}
