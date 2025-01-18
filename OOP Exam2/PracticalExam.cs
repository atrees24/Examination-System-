using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam2
{
    internal class PracticalExam : IExam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }


        public PracticalExam(int time, int numberOfQuestions, List<Question> questions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }

        public void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            foreach (var question in Questions)
            {
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                }
                Console.Write("Enter your answer: ");
                int userAnswer = int.Parse(Console.ReadLine());
                Console.WriteLine($"The correct answer is: {question.RightAnswer.AnswerText}");
            }
        }
    }

}

