using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8._2
{
    class Driver
    {
        public void driver_test()
        {
            bool status = false;

            while (status == false)
            {
                Employee firstEmployee = new Employee();
                firstEmployee.SetNumber();
                firstEmployee.SetFirstName();
                firstEmployee.SetLastName();
                firstEmployee.SetTotalSales();
                Console.WriteLine();
                firstEmployee.DisplayInfo();

                Console.WriteLine("First Employee's take home pay is: {0:C2}", firstEmployee.TakeHomePay());

                bool status1 = false;
                while (status1 == false)
                {
                    Console.Write("Type [1] to restart or [0] to quit: ");
                    string str_dec = Console.ReadLine();
                    bool valid = int.TryParse(str_dec, out int decision);
                    if ((valid == true) && (decision == 1 || decision == 0))
                    {
                        if (decision == 1)
                        {
                            Console.Clear();
                            status1 = true;
                        }
                        if (decision == 0)
                        {
                            Console.Clear();
                            status = true;
                            status1 = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input.");
                    }
                }
            }
        }
    }
}