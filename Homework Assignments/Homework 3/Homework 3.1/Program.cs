using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
       
            while (true)
            {
                
                Console.Write("Compute area of (a) circle, (b) rectangle, (c) cylinder or type 'quit': ");
                string input = Console.ReadLine();
                char choice;
                
                if (input == "quit")
                {
                    Console.WriteLine("\nGoodbye\n");
                    break;
                }
                else
                {
                    
                    bool valid = char.TryParse(input, out choice);

                    if (valid)
                    {
                        choice = Convert.ToChar(input);
                        switch (choice)
                        {
                            case 'a': // Circle

                                Console.Write("\nEnter the radius: ");
                                string radius_1 = Console.ReadLine();
                                double radius = Convert.ToDouble(radius_1);

                                double aCircle = (Math.PI) * (radius * radius);
                                Console.WriteLine("\nArea of the circle = {0} unit^2\n", Math.Round(aCircle, 3));

                                break;

                            case 'b': // Rectangle

                                Console.Write("\nEnter the length: ");
                                string length_1 = Console.ReadLine();
                                double length = Convert.ToDouble(length_1);

                                Console.Write("\nEnter the width: ");
                                string width_1 = Console.ReadLine();
                                double width = Convert.ToDouble(width_1);

                                double aRectangle = length * width;
                                Console.WriteLine("\nArea of the rectangle = {0} unit^2\n", Math.Round(aRectangle, 3));

                                break;

                            case 'c': // Cylinder

                                Console.Write("\nEnter the radius: ");
                                string radiusC_1 = Console.ReadLine();
                                double radiusC = Convert.ToDouble(radiusC_1);

                                Console.Write("\nEnter the height: ");
                                string height_1 = Console.ReadLine();
                                double height = Convert.ToDouble(height_1);


                                double aCylinder = (2 * (Math.PI) * radiusC * height) + (2 * (Math.PI) * (radiusC * radiusC));
                                Console.WriteLine("\nArea of the cylinder = {0} unit^2\n", Math.Round(aCylinder, 3));

                                break;

                            default:
                                Console.WriteLine("\nInvalid input\n");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input\n");
                    }

                }
                    
                


            }
            
        }
    }
}
