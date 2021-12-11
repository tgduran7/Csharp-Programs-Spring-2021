using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9._1
{
    class Grocery
    {
        Milk my_milk;
        Bread my_bread;
        Eggs my_eggs;

        public Grocery(Milk m, Bread b, Eggs e)
        {
            my_milk = m;
            my_bread = b;
            my_eggs = e;
        }
        public double Expense()
        {
            double m = my_milk.Total_Price();
            double b = my_bread.Total_Price();
            double e = my_eggs.Total_Price();
            double totalExpense = m + b + e;
            return totalExpense;
        }
        public override string ToString()
        {
            string output = string.Format("-----------------------------------Grocery List-----------------------------------\n" + my_milk.ToString() + "\n" + my_bread.ToString() + "\n" + my_eggs.ToString() + "\nTotal = {0:C2}",Expense());
            return output;
        }
    }
}
