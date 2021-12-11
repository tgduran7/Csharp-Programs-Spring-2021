using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9._1
{
    class Bread
    {
        private double price;
        private int quantity;

        public Bread()
        {
            price = 2.50;
            quantity = 0;
        }
        public Bread(double p, int q)
        {
            price = p;
            quantity = q;
        }
        public Bread(double p)
        {
            price = p;
            quantity = 0;
        }
        public Bread(int q)
        {
            price = 2.50;
            quantity = q;
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Total_Price()
        {
            double totalprice = quantity * price;
            return totalprice;
        }
        public override string ToString()
        {
            string output = string.Format("Bread has a unit price of {0:C2}, has a quantity of {1}, and totals to {2:C2}", price, quantity, Total_Price());
            return output;
        }
    }
}
