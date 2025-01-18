using System.Diagnostics;

namespace OOP_Exam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(10,"C#");
            sub.CreateExam();
            Console.Clear();
            Console.Write("Do You Want to start the Exam ( y | n ): ");

            if(char.Parse(Console.ReadLine())=='y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                sub.Exam.ShowExam();
                Console.WriteLine($"the time is : {sw.Elapsed}");
            }



            Console.ReadLine();
        }
    }
}
