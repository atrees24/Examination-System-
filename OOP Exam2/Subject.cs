using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam2
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public IExam Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
        public void CreateExam()
        {
            Console.Write("Enter the type of exam (1 for Final, 2 for Practical): ");
            int examType = int.Parse(Console.ReadLine());
            Console.Write("Enter the time of the exam: ");
            int time = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of questions: ");
            int numberOfQuestions;
            int.TryParse(Console.ReadLine(),out numberOfQuestions);
            List<Question> questions = new List<Question>();

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.Write("Enter the header: ");
                string header = Console.ReadLine();
                Console.Write("Enter the body: ");
                string body = Console.ReadLine();
                Console.Write("Enter the mark: ");
                int mark = int.Parse(Console.ReadLine());

                int questionType;
                if (examType == 2)
                {
                    questionType = 2;
                }
                else
                {
                    Console.Write("Enter the type (1 for T/F, 2 for MCQ): ");
                    int.TryParse(Console.ReadLine(), out questionType);
                }
                
                if (questionType == 1)
                {
                    Console.Write("Is the answer true or false?");
                    bool isTrue;
                    bool.TryParse(Console.ReadLine(), out isTrue);
                    questions.Add(new TrueFalseQuestion(header, body, mark, isTrue));
                }

                else if (questionType == 2)
                {
                    Console.Write("Enter the <number> of choices: ");
                    int numberOfChoices = int.Parse(Console.ReadLine());
                    List<string> choices = new List<string>();

                    for (int j = 0; j < numberOfChoices; j++)
                    {
                        Console.Write("Enter the choice : ");
                        string choice = Console.ReadLine();
                        choices.Add(choice);
                    }

                    Console.Write("Enter the correct answer id: ");
                    int rightAnswerId = int.Parse(Console.ReadLine());
                    questions.Add(new MCQQuestion(header, body, mark, choices, rightAnswerId));
                }
            }

            if (examType == 1)
            {
                Exam = new FinalExam(time, numberOfQuestions, questions);
            }
            else if (examType == 2)
            {
                Exam = new PracticalExam(time, numberOfQuestions, questions);
            }
        }
    }
}

