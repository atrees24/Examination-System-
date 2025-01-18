using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam2
{
    internal class FinalExam : IExam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }
        public int Grade { get; set; }

        public FinalExam(int time, int numberOfQuestions, List<Question> questions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }

        public void ShowExam()
        {
            Console.WriteLine("Final Exam");
            foreach (var question in Questions)
            {
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                }
                Console.Write("Enter your (Answer Number): ");
                int userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == question.RightAnswer.AnswerId)
                {
                    Grade += question.Mark;
                }
            }
            Console.WriteLine($"Your grade is: {Grade}");
        }
    }
}
