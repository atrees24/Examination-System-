using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam2
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, List<string> choices, int rightAnswerId)
        : base(header, body, mark)
        {
            int answerId = 1;
            foreach (string choice in choices)
            {
                Answer answer = new Answer() { AnswerId = answerId, AnswerText = choice };
                Answers.Add(answer);
                answerId++;
            }

            for (int i = 0; i < Answers.Count; i++)
            {
                if (Answers[i].AnswerId == rightAnswerId)
                {
                    RightAnswer = Answers[i];
                    break;
                }
            }
        }

        public override string GetQuestionType()
        {
            return "MCQ";
        }
    }
}
