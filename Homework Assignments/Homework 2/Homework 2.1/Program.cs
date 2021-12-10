using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your 5-digit integer: ");
            string str_5d = Console.ReadLine();
            int number = Convert.ToInt32(str_5d);

            int digit1 = number / 10000;
            Console.Write("" + digit1);

            int digit2 = (number % 10000) / 1000;
            Console.Write(" " + digit2);

            int digit3 = (number % 1000) / 100;
            Console.Write(" " + digit3);

            int digit4 = (number % 100) / 10;
            Console.Write(" " + digit4);

            int digit5 = number % 10;
            Console.Write(" " + digit5);

            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
