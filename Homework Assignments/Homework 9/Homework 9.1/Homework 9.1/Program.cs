using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk milk1 = new Milk(1);
            Console.WriteLine(milk1.ToString());
            Bread bread1 = new Bread(2);
            Console.WriteLine("Your quantity for bread: " + bread1.Quantity);
            Eggs eggs1 = new Eggs();
            eggs1.Quantity = 3;
            Console.WriteLine(eggs1.ToString());

            Grocery list1 = new Grocery(milk1, bread1, eggs1);
            Console.WriteLine("The total for list1 is: {0:C2}",list1.Expense());
            Console.WriteLine(list1.ToString());
            


        }
    }
}
