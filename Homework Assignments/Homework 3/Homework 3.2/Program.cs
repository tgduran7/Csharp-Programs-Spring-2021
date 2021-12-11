using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._2
{
    class Program
    {
        static void Main(string[] args)
        {


            string input;
            double grade;

            while(true)
            {
                Console.Write("Enter the student's grade or type 'exit': ");
                input = Console.ReadLine();

                if (input == "exit")
                {
                    break;
                }
                bool valid = double.TryParse(input, out grade);

                if ((valid) && (grade >= 0) && (grade <= 100))
                {
                    grade = Convert.ToDouble(input);
                    switch (grade) // Requirement
                    {
                        case double n when (100.0 >= n && n >= 90.0):

                            Console.WriteLine("\nGrade: A\n");

                            break;

                        case double n when (90.0 > n && n >= 80.0):

                            Console.WriteLine("\nGrade: B\n");
                            break;

                        case double n when (80.0 > n && n >= 70.0):

                            Console.WriteLine("\nGrade: C\n");
                            break;

                        case double n when (70.0 > n && n >= 60.0):

                            Console.WriteLine("\nGrade: D\n");
                            break;

                        case double n when (60.0 > n):

                            Console.WriteLine("\nGrade: F\n");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid grade.\n");
                    break;
                }

            }
            
           
        }
    }
}
