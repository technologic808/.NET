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


        // Timer Logic
    }

}
