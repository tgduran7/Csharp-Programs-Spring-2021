using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of miles: ");
            double mile = Convert.ToDouble(Console.ReadLine());

            double kilometer = mile * 1.60934;

            Console.WriteLine();
            Console.Write(kilometer + " km\n");

            Console.ReadKey();

        }
    }
}
