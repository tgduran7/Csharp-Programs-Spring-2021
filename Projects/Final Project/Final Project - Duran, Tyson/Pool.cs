using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project___Duran__Tyson
{
    class Pool
    {
        public Temperature temperature;
        public Location location;
        public static int Count = 0;

        public Pool()
        {
            Count++;
        }
        public Pool(Temperature t, Location l)
        {
            temperature = t;
            location = l;
            Count++;

        }

        public override string ToString()
        {
            string output = "Temperature: " + temperature + " at " + location;
            return output;
        }

        
    }
}
