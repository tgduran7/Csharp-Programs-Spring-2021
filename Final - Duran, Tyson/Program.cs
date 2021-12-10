using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final___Duran__Tyson
{
    class Program
    {
        static void Main(string[] args)
        {
            

            GraphObject[] item = new GraphObject[4];
            item[0] = new RightTriangle(6, 8);
            item[1] = new Square(8);
            item[2] = new RightTriangle(5, 15); 
            item[3] = new Square(7); 

            for(int i = 0; i < item.Length; i++)
            {
                Console.WriteLine(item[i].ToString());
            }
            Utilities.FindLargest(item);

        }
    }
}
