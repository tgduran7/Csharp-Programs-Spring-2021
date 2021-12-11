using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            while (end == false)
            {
                Console.Write("Enter the first integer in the range: ");
                string str_lower = Console.ReadLine();
                Console.Write("Enter the last integer in the range: ");
                string str_upper = Console.ReadLine();

                bool valid = Int32.TryParse(str_lower, out int lower);
                bool valid2 = Int32.TryParse(str_upper, out int upper);
                if (valid && valid2)
                {
                    do
                    {
                        isPerfect(lower);
                        lower++;
                    } while (lower <= upper);
                    Console.WriteLine();

                    bool decision = false;
                    while (decision == false)
                    {
                        Console.Write("\nEnter {1} to RESTART or {-1} to CLOSE: ");
                        string str_decision = Console.ReadLine();
                        bool valid3 = Int32.TryParse(str_decision, out int choice);

                        if (!valid3 || choice != -1 || choice != 1)
                        {
                            Console.WriteLine("\nPlease enter a valid interger\n");
                        }
                        if (valid && choice == 1)
                        {
                            decision = true;
                        }
                        if (valid && choice == -1)
                        {
                            decision = true;
                            end = true;
                        }
                    }
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid integer.\n");
                }
            }
        }
        static void isPerfect(int x)
        {
            int sum = 0;
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == x && sum != 0)
            {
                Console.Write("\n" + sum + " is a Perfect Number. The Divisors are: ");
                for (int i = 1; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        Console.Write(i + ", ");
                    }


                }
                Console.WriteLine();
            }
        }
    }
}
