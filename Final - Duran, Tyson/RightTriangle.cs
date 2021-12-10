using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final___Duran__Tyson
{
    class RightTriangle : GraphObject
    {
        int height;
        int bas;

        public RightTriangle() : base()
        {
            height = 0;
            bas = 0;
        }
        public RightTriangle(int h, int b) : base()
        {
            height = h;
            bas = b;
        }
        public override double cal_area()
        {
            area = 0.5 * height * bas;
            return Math.Round(area,2);
        }

        public override double cal_perimeter()
        {
            double part1 = height + bas;
            double part2 = part1 + (Math.Sqrt(Math.Pow(bas, 2) + Math.Pow(height, 2)));
            perimeter = part2;
            return Math.Round(perimeter,2);
        }
        public override string ToString()
        {
            return "A triangle, height = " + height + ", base = " + bas+ ", area = " + cal_area() + ", perimeter = " + cal_perimeter();
        }
    }
}
