using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8._1
{
    class Test
    {
       public void testing()
        {
            
            Employee firstEmployee = new Employee(12345, "Tyson", "Duran", 10000);
            firstEmployee.DisplayInfo();
            Console.WriteLine("First Employee's annual pay is {0:C2}\n", firstEmployee.AnnualPay());

            Employee secondEmployee = new Employee(54321, "John", "Doe", 50000);
            secondEmployee.DisplayInfo();
            Console.WriteLine("Second Employee's annual pay is {0:C2}\n", secondEmployee.AnnualPay());

            Employee thirdEmployee = new Employee(15432);
            thirdEmployee.DisplayInfo();
        }

    }
}
