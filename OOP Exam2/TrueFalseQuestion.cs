using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam2
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark, bool isTrue)
        : base(header, body, mark)
        {
            Answers.Add(new Answer() { AnswerId = 1, AnswerText = isTrue ? "True" : "False" });
            RightAnswer = new Answer() { AnswerId = 1, AnswerText = isTrue ? "True" : "False" };
        }

        public override string GetQuestionType()
        {
            return "True/False";
        }
    }
}
