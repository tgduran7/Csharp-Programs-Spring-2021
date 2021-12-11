using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7._2
{
    class Program
    {
        static void Main(string[] args)
        {


            double result1 = 1 + 2 + 4 + 8 + 16 + 32 + 64 + 128 + 256 + 512 + 1024 + integerPower(2, 10);
            Console.WriteLine(result1);
        }

        static int integerPower(int b, int exp)
        {
            int result = 1;
            for (int i = 0; i < exp; i++)
            {
                result *= b;
            }
            return result;
        }
    }
}
