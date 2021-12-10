using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final___Duran__Tyson
{
    class GraphObject
    {
        protected double area;
        protected double perimeter;

        public GraphObject()
        {
            area = 0;
            perimeter = 0;
        }
        public GraphObject(double a, double p)
        {
            area = a;
            perimeter = p;
        }
        public virtual double cal_area()
        {
            return Math.Round(area,2); // Stored as the protected member
        }
        public virtual double cal_perimeter() 
        {
            return Math.Round(perimeter,2); // Stored as the protected member
        }
    }
}
