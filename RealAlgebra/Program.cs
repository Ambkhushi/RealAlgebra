using System;
using ShapeAreaLib;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l, w, s, r, b, h,result;
            string choice;
            do
            {
                Console.WriteLine("Choose \n 1. Rectangle\n 2. Square\n 3. Circle\n4. Triangle ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Rectangle rect = new Rectangle();
                            Console.WriteLine("Enter lenght:");
                            l = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter width:");
                            w = double.Parse(Console.ReadLine());
                            result = rect.Area(l, w);
                            Console.WriteLine("Area of Rectangle: " +result);
                            break;
                        }
                    case 2:
                        {
                            Square square = new Square();
                            Console.WriteLine("Enter sides of square:");
                            s = double.Parse(Console.ReadLine());
                            result = square.Area(s);
                            Console.WriteLine("Area of Square: ",+result);
                            break;
                        }
                    case 3:
                        {
                            Circle circle = new Circle();
                            Console.WriteLine("Enter Radius of circle:");
                            r = double.Parse(Console.ReadLine());
                            result = circle.Area(r);
                            Console.WriteLine("Area of Circle: ",+result);
                            break;
                        }
                    case 4:
                        {
                            Triangle tri = new Triangle();
                            Console.WriteLine("Enter base lenght:");
                            b = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter hight:");
                            h = double.Parse(Console.ReadLine());
                            result = tri.Area(b, h);
                            Console.WriteLine("Area of Triangle: ",+result);
                            break;
                        }
                    default: { Console.WriteLine("Invalid Operation Choice!!!"); break; }
                }
                Console.WriteLine("Press y to Continue");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
