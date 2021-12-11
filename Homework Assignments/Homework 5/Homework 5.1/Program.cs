using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endProgram = false;

            while (endProgram == false)
            {


                int i = 0;

                Console.Write("Enter the amount of students: ");
                string str_amountStudents = Console.ReadLine();

                bool valid = Int32.TryParse(str_amountStudents, out int amountStudents);

                if (!valid || amountStudents < 1)
                {
                    Console.WriteLine("\nPlease enter a valid amount of students.");
                }
                else
                {

                    string[] names = new string[amountStudents];
                    double[] scores = new double[amountStudents];
                    double total = 0;

                    while (i < amountStudents)
                    {
                        Console.Write("\nEnter the student's name: ");
                        names[i] = Console.ReadLine();

                        Console.Write("Enter the student's score: ");
                        scores[i] = Convert.ToDouble(Console.ReadLine());

                        total = total + scores[i];

                        i++;
                    }

                    // HEADER
                    string headerName = "Name";
                    string headerScore = "Score";
                    string str_header = string.Format("\n{0,-10} {1,-10}", headerName, headerScore);
                    Console.WriteLine(str_header);

                    // AVERAGE
                    double averageScore = total / amountStudents;

                    // OUTPUT DISPLAY
                    for (i = 0; i < amountStudents; i++)
                    {
                        string str_output = string.Format("{0,-10} {1,-10}", names[i], scores[i].ToString());
                        Console.WriteLine(str_output);

                    }

                    // HIGHEST SCORE
                    string str_highest = "";
                    double maxScore = scores[0];
                    string maxName = names[0];
                    for (i = 0; i < amountStudents; i++)
                    {
                        if (scores[i] >= maxScore)
                        {
                            maxScore = scores[i];
                            maxName = names[i];
                        }
                    }
                    for (i = 0; i < amountStudents; i++)
                    {
                        if (scores[i] == maxScore)
                        {
                            str_highest += string.Format("\n{0} has the highest score {1} in the class.", names[i], scores[i].ToString());
                        }
                    }



                    // AVERAGE COUNTER
                    int averageCounter = 0;
                    for (i = 0; i < amountStudents; i++)
                    {
                        if (scores[i] >= averageScore)
                        {
                            averageCounter++;
                        }
                    }
                    Console.WriteLine(str_highest);
                    Console.WriteLine("\nThe average score of the class is " + Math.Round(averageScore, 3));
                    Console.WriteLine("{0} students are above average score.", averageCounter);

                    

                    bool decision2 = false;

                    while (decision2 == false)
                    {
                        Console.Write("\nDo you want to restart the program? enter '1' to restart or '2' to quit: ");
                        string str_decision = Console.ReadLine();
                        bool valid2 = Int32.TryParse(str_decision, out int decision);

                        if (!valid2)
                        {
                            Console.WriteLine("\nPlease enter a valid input. ");

                        }
                        else if (valid2 && decision == 2)
                        {

                            decision2 = true;
                            endProgram = true;
                            
                        }
                        else if (valid2 && decision == 1)
                        {
                            decision2 = true;
                        }
                    }
                    Console.Clear();
                }
                
            }
        }
    }
}
