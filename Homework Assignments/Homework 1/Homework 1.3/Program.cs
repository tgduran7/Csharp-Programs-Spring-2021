using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Homework: ");
            double homework = Convert.ToDouble(Console.ReadLine());
            double homework1 = 0.1 * homework;

            Console.Write("\nProjects: ");
            double projects = Convert.ToDouble(Console.ReadLine());
            double projects1 = 0.25 * projects;

            Console.Write("\nQuizzs: ");
            double quizzes = Convert.ToDouble(Console.ReadLine());
            double quizzes1 = 0.2 * quizzes;

            Console.Write("\nExams: ");
            double exams = Convert.ToDouble(Console.ReadLine());
            double exams1 = 0.2 * exams;

            Console.Write("\nFinal Exam: ");
            double finalexams = Convert.ToDouble(Console.ReadLine());
            double finalexams1 = 0.25 * finalexams;

            double total = homework1 + projects1 + quizzes1 + exams1 + finalexams1;

            Console.WriteLine("\nYour final grade is: " + Math.Round(total, 1));

            Console.ReadKey();
        }
    }
}
