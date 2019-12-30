using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Question
    {
        public int Id { get; set; }
        public String QuestionString { get; set; }
        public int Answer { get; set; }
        public String OptionOne { get; set; }
        public String OptionTwo { get; set; }
        public String OptionThree { get; set; }
        public String OptionFour { get; set; }

        public override string ToString()
        {
            return QuestionString;
        }
    }
}
