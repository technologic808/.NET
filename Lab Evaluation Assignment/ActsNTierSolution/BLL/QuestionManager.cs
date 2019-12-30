using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class QuestionManager
    {
        // Get Questions
        public static List<Question> GetQuestions() {
            return QuestionRepository.GetQuestions();
        }

        // Randomize Questions

        private static Random rng = new Random();

        public static void Shuffle(this IList<Question> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Question value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        // Timer Logic
    }

}
