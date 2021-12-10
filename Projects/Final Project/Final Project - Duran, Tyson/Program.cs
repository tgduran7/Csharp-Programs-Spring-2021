using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Final_Project___Duran__Tyson
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList poolList = new ArrayList();
            Random random = new Random();

            // TEMPERATURES
            Temperature[] temp = new Temperature[7];
            for (int i = 0; i < 7; i++)
            {
                temp[i] = new Temperature(random.Next(98, 105));
            }

            // LOCATIONS
            Location[] loc = new Location[7];

            loc[0] = new Location(4, 8); // A
            loc[1] = new Location(1, 3); // B
            loc[2] = new Location(4, 2); // C
            loc[3] = new Location(13, 1); // D
            loc[4] = new Location(12, 9); // E
            loc[5] = new Location(10, 5); // F
            loc[6] = new Location(6, 6);  // G
             
            // POOLS
            Pool[] p = new Pool[7];
            for (int i = 0; i < 7; i++)
            {
                p[i] = new Pool(temp[i], loc[i]);
                Console.WriteLine("There are " + Pool.Count + " pool(s) created.");
                poolList.Add(p[i]);
            }

            Location location = new Location(0, 0);
            Console.WriteLine("Path is : ");
            Pool closest = null;
            while (poolList.Count > 0)
            {
                double dist = double.MaxValue;
                foreach (Pool i in poolList)
                {

                    //double min = i.location.FindDistance(location);
                    if (i.location.FindDistance(location) < dist)
                    {
                        closest = i;
                        dist = i.location.FindDistance(location);
                    }

                }
                Console.Write(closest + " >> ");
                closest.temperature.Degree = 100;
                location = closest.location;
                poolList.Remove(closest);

            }
        }
    }
}
