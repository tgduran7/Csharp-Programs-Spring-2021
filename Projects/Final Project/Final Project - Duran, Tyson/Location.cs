using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project___Duran__Tyson
{
    class Location
    {
        int x;
        int y;

        public Location(int a, int b)
        {
            x = a;
            y = b;

        }
        
        public int X
        {
            get { return x; }
            set { x = value;}
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public double FindDistance(Location sloc)
        {
            return Math.Sqrt((x - sloc.x) * (x - sloc.x) + (y - sloc.y) * (y - sloc.y));
        }

        public override string ToString()
        {
            string output = "Location: " + x + " & " + y;
            return output;
        }
    }
}
