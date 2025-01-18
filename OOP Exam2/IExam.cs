using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam2
{
    internal interface IExam
    {
        int Time { get; set; }
        int NumberOfQuestions { get; set; }
        List<Question> Questions { get; set; }
        void ShowExam();
    }
}
