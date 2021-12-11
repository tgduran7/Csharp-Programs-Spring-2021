using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8._1
{
    class Employee
    {
        // Attributes

        private int employee_number;
        private string employee_first_name;
        private string employee_last_name;
        private double monthly_salary;

        // Behaviors

        public Employee()
        {
            employee_number = 0;
            employee_first_name = "N/A";
            employee_last_name = "N/A";
            monthly_salary = 0;
        }

        public Employee(int employeeNumber, string firstName, string lastName, double monthlySalary)
        {
            employee_number = employeeNumber;
            employee_first_name = firstName;
            employee_last_name = lastName;
            monthly_salary = monthlySalary;
        }

        public Employee(int employeeNumber)
        {
            employee_number = employeeNumber;
            employee_first_name = "N/A";
            employee_last_name = "N/A";
            monthly_salary = 0;
        }
        public Employee(string firstName, string lastName)
        {
            employee_number = 0;
            employee_first_name = firstName;
            employee_last_name = lastName;
            monthly_salary = 0;
        }
      

        public double AnnualPay()
        {
            double annualPay = 12 * monthly_salary;
            return annualPay;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Employee Number: {0}\nName: {1} {2}\nMonthly Salary: {3:C2}\n", employee_number.ToString(), employee_first_name, employee_last_name, monthly_salary);
        }
    }
}
