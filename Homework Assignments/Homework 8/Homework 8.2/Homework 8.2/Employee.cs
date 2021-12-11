using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8._2
{
    class Employee
    {
        // Attributes

        private int employee_number;
        private string employee_first_name;
        private string employee_last_name;
        private double total_sales;

        // Behaviors

        public Employee()
        {
            employee_number = 0;
            employee_first_name = "N/A";
            employee_last_name = "N/A";
            total_sales = 0;
        }

        public Employee(int employeeNumber, string firstName, string lastName, double totalSales)
        {
            employee_number = employeeNumber;
            employee_first_name = firstName;
            employee_last_name = lastName;
            total_sales = totalSales;
        }
        public Employee(int employeeNumber)
        {
            employee_number = employeeNumber;
            employee_first_name = "N/A";
            employee_last_name = "N/A";
            total_sales = 0;
        }

        public Employee(string firstName, string lastName)
        {
            employee_number = 0;
            employee_first_name = firstName;
            employee_last_name = lastName;
            total_sales = 0;
        }

        public int GetNumber()
        {
            return employee_number;
        }

        public void SetNumber()
        {
            bool redo = false;
            while (redo == false)
            {
                Console.Write("Please enter the EMPLOYEE #: ");
                string str_num = Console.ReadLine();
                bool valid = int.TryParse(str_num, out int num);
                if (str_num == "" || valid == false || num < 0)
                {
                    Console.WriteLine("Invalid Input. Re-enter the EMPLOYEE #.");
                }
                else
                {
                    employee_number = num;
                    redo = true;
                }
            }
        }

        public string GetFirstName()
        {
            return employee_first_name;
        }

        public void SetFirstName()
        {
            bool redo = false;
            while (redo == false)
            {
                Console.Write("Please enter the FIRST NAME: ");
                string fn = Console.ReadLine();
                if (fn == "")
                {
                    Console.WriteLine("Invalid Input. Re-enter a FIRST NAME.");
                }
                else
                {
                    employee_first_name = fn;
                    redo = true;
                }
            }
        }

        public string GetLastName()
        {
            return employee_last_name;
        }

        public void SetLastName()
        {
            bool redo = false;
            while (redo == false)
            {
                Console.Write("Please enter the LAST NAME: ");
                string ln = Console.ReadLine();
                if (ln == "")
                {
                    Console.WriteLine("Invalid Input. Re-enter the LAST NAME.");
                }
                else
                {
                    employee_last_name = ln;
                    redo = true;
                }
            }
        }

        public double GetTotalSales()
        {
            return total_sales;
        }

        public void SetTotalSales()
        {
            bool redo = false;
            while (redo == false)
            {
                Console.Write("Please enter the TOTAL SALES: ");
                string str_ts = Console.ReadLine();
                bool valid = int.TryParse(str_ts, out int ts);
                if (str_ts == "" || valid == false || ts < 0)
                {
                    Console.WriteLine("Invalid Input. Re-enter the TOTAL SALES.");
                }
                else
                {
                    total_sales = ts;
                    redo = true;
                }
            }
        }

        public double TakeHomePay()
        {
            double take_home = total_sales * 0.09;
            double total = take_home - ((take_home * 0.18) + (take_home * 0.1) + (take_home * 0.06));
            return total;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Employee Number: {0}\nName: {1} {2}\nTotal Sales: {3:C2}\n", employee_number, employee_first_name, employee_last_name, total_sales);
        }
    }
}
