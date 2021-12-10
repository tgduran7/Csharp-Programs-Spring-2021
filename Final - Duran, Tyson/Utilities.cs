using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Final___Duran__Tyson
{
    class Utilities
    {
        public static void FindLargest(GraphObject[] shapes)
        {
            ArrayList shapeList = new ArrayList();
            shapeList.AddRange(shapes);
            GraphObject itemGreatestArea = null;
            GraphObject itemGreatestPerimeter = null;
            double greatestArea = 0;
            double greatestPerimeter = 0;
            foreach (GraphObject obj in shapes)
            {
                if (obj.cal_area() > greatestArea)
                {
                    greatestArea = obj.cal_area();
                    itemGreatestArea = obj;

                }
                if (obj.cal_perimeter() > greatestPerimeter)
                {
                    greatestPerimeter = obj.cal_perimeter();
                    itemGreatestPerimeter = obj;

                }
            }
            Console.WriteLine(itemGreatestArea + " HAS THE GREATEST AREA OF " + greatestArea);
            Console.WriteLine(itemGreatestPerimeter + " HAS THE GREATEST PERIMETER OF " + greatestPerimeter);
        }
    }
}
