using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialLinda = 1000.00;
            double initialJohn = 1000.00;

            string ageHeading = "Age";
            string LindasAccount = "Linda's Account";
            string JohnsAccount = "John's Account";

            string str_header = string.Format("{0,-10} {1,-20} {2,-20}", ageHeading, LindasAccount, JohnsAccount);
            Console.WriteLine(str_header);
            Console.WriteLine("--------------------------------------------------------------");


            int age = 20;
            int count = 0;
            int n = 0;
            while (n <= 40)
            {
               

                double totalLinda = 1000 * (Math.Pow((1 + 0.06), n)-1);
                double finalLinda = totalLinda + initialLinda;
                //finalLinda.ToString("C2");

                double totalJohn = 1000 * (Math.Pow((1 + 0.015), n)-1);
                double finalJohn = totalJohn + initialJohn;
                //Console.WriteLine(finalJohn);

                string str_output = string.Format("{0,-10} {1,-20} {2,-20}\n", age, finalLinda.ToString("C"), finalJohn.ToString("C"));
                age = age + 10;
                count = (age + 10)/age;

                n = n + 10;

                
                Console.Write(str_output);
            }
            Console.WriteLine();
        }
    }
}
