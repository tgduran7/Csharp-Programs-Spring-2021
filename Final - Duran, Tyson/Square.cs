using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final___Duran__Tyson
{
    class Square : GraphObject 
    {
        int segment;

        public Square() : base()
        {
            segment = 0;
        }
        public Square(int s) : base()
        {
            segment = s;
        }

        public override double cal_area()
        {
            area = segment * segment;
            return Math.Round(area,2);
        }

        public override double cal_perimeter()
        {
            perimeter = 4* segment;
            return Math.Round(perimeter,2);
        }
        public override string ToString()
        {
            return "A square, segment = " + segment + ", area = " + cal_area() + ", perimeter = " + cal_perimeter();
            
        }
    }
}
