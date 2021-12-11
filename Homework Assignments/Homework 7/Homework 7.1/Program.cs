using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of students: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] score = new int[amount];
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write("Enter student #" + (i+1).ToString() + "'s score: ");
                score[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            if (Search(100, score) == -1)
            {
                Console.WriteLine("No students earned 100%.");
            }
            else
            {
                Console.WriteLine("Student #" + ((Search(100, score)) + 1) + " earned 100%.");
            }

        }

        static int Search(int key, int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
