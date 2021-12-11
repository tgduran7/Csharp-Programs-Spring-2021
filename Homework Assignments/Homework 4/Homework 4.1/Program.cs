using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci Series

            bool quit = false;

            while (quit == false)
            {
                
                Console.Write("Enter the nth term or type 'quit': ");
                string str_n = Console.ReadLine();
                Console.Clear();


                if (str_n == "quit")
                {
                    break;
                }
                bool valid = Int32.TryParse(str_n, out int n);

                if (valid && n >= 0)
                {

                    int a = 1, b = 0, c = 0;
                    int countTable = 0;

                    for (int i = 1; i <= n; i++)
                    {
                        c = a + b;
                        a = b;
                        b = c;


                        if (countTable < 5)
                        {
                            string str_c = string.Format("{0,-10}", c);
                            Console.Write(str_c);
                            
                            // Full Dimensions
                            if (countTable == 5 && i == n)
                            {
                                Console.WriteLine("\n\nn = " + n);
                                Console.WriteLine("\n");
                            }
                            // Partial Dimensions
                            else if (countTable <= 5 && i == n)
                            {
                                Console.WriteLine("\n\nn = " + n);
                                Console.WriteLine("\n");
                            }
                            countTable++;

                        }
                        else
                        {
                            Console.WriteLine();
                            string str_c = string.Format("{0,-10}", c);
                            Console.Write(str_c);
                            countTable = 1;

                            if (countTable == 1 && i == n)
                            {
                                Console.WriteLine("\n\nn = " + n);
                                Console.WriteLine("\n");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid input.\n");
                }

            }
        }
    }
}