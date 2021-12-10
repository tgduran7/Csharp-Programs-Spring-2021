using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project___Duran__Tyson
{
    class Temperature
    {
        int degree;
        string scale;

        public Temperature()
        {
            degree = 0;
            scale = "F";
        }
        public Temperature(int d)
        {
            degree = d;
            scale = "F";
        }

        public int Degree
        {
            get { return degree; }
            set
            {
                int password = 12345;
                Console.Write("Enter the maintenance crew password: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == password)
                {
                    Console.WriteLine("Access Granted.\nThe pool is now adjusted.");
                    degree = value;
                }
            }
        }

        public override string ToString()
        {
            string output = degree + scale;
            return output;
        }
    }
}
