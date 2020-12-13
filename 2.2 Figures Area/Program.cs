using System;
using System.Globalization;

namespace _2._2_Figures_Area
{
    class Program
    {
        static int Main(string[] args)
        {
            string figureChosen;
            string[] input;
            double radius;
            double a, b, c;
            double area;
            double perimeter;
            const double pi = 3.14;
            const int maxValue = 10000;

            if (args != null && args.Length > 0 && false)
            {
                figureChosen = args[0];

                switch (figureChosen)
                {
                    case "circle":
                        {
                            if (Double.TryParse(args[1], out radius))
                            {
                                if (radius <= 0 || radius > maxValue)
                                {
                                    return -1;
                                }
                                else
                                {
                                    area = radius * radius * pi;
                                    Console.WriteLine($"{area}");
                                }
                            }
                            else
                            {
                                return -1;
                            }
                            break;
                        }
                    case "triangle":
                        {
                            if (args.Length < 4)
                            {
                                return -1;
                            }
                            else
                            {
                                if (Double.TryParse(args[1], out a) && Double.TryParse(args[2], out b) && Double.TryParse(args[3], out c))
                                {
                                    if (a <= 0 || b <= 0 || c <= 0 || a > maxValue || b > maxValue || c > maxValue)
                                    {
                                        return -1;
                                    }
                                    else if (a + b <= c || a + c <= b || b + c <= a)
                                    {
                                        return -1;
                                    }
                                    else
                                    {
                                        perimeter = (a + b + c) / 2.0;
                                        area = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
                                        Console.WriteLine($"{area}");
                                    }
                                }
                                else
                                {
                                    return -1;
                                }
                            }
                            break;
                        }
                    case "square":
                        {
                            if (Double.TryParse(args[1], out a))
                            {
                                if (a <= 0 || a > maxValue)
                                {
                                    return -1;
                                }
                                else
                                {
                                    area = a * a;
                                    Console.WriteLine($"{area}");
                                }
                            }
                            else
                            {
                                return -1;
                            }
                            break;
                        }
                    case "rectangle":
                        {
                            if (args.Length < 3)
                            {
                                return -1;
                            }
                            else
                            {
                                if (Double.TryParse(args[1], out a) && Double.TryParse(args[2], out b))
                                {
                                    if (a <= 0 || b <= 0 || a > maxValue || b > maxValue)
                                    {
                                        return -1;
                                    }
                                    else
                                    {
                                        area = a * b;
                                        Console.WriteLine($"{area}");
                                    }
                                }
                                else
                                {
                                    return -1;
                                }
                            }
                            break;
                        }
                    default:
                        {
                            return -1;
                        }
                }
                Console.ReadKey();
                return 1;
            }
            else
            {
                // Introduction.
                Console.WriteLine("Task 2.2. Made by Aleksey Kharchenko.");
                Console.WriteLine("My program calculates areas of given figures:\n");
                Console.WriteLine("\tCircle's area via it's radius");
                Console.WriteLine("\tTriangle's area via it's three sides,");
                Console.WriteLine("\tSquare's area via it's one side,");
                Console.WriteLine("\tRectangle's area via it's two sides,");


                // Processing inputs.
                ConsoleKeyInfo keyCode = new ConsoleKeyInfo();


                while (keyCode.Key != ConsoleKey.Escape)
                {
                    Console.WriteLine("\n\nPlease write the figure that you want to process:");
                    Console.WriteLine("Circle, triangle, square, rectangle.\n");
                    figureChosen = Console.ReadLine().ToLower();

                    switch (figureChosen)
                    {
                        case "circle":
                            {
                                Console.Write("Please input radius of your circle: ");
                                input = Console.ReadLine().Split();

                                if (Double.TryParse(input[0], out radius))
                                {
                                    if (radius <= 0 || radius > maxValue)
                                    {
                                        Console.WriteLine("You should input positive numbers and not bigger than 10000.");
                                    }
                                    else
                                    {
                                        area = radius * radius * pi;
                                        Console.WriteLine($"Here is an area of circle: {area}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid format. Please use digits and not any kind of symbols.");
                                }
                                break;
                            }
                        case "triangle":
                            {
                                Console.Write("Please input three sides of your triange: ");
                                input = Console.ReadLine().Split();
                                if (input.Length < 3)
                                {
                                    Console.WriteLine("Too few elements. Please enter specifically three sides.");
                                }
                                else
                                {

                                    if (Double.TryParse(input[0], out a) && Double.TryParse(input[1], out b) && Double.TryParse(input[2], out c))
                                    {
                                        if (a <= 0 || b <= 0 || c <= 0 || a > maxValue || b > maxValue || c > maxValue)
                                        {
                                            Console.WriteLine("You should input positive numbers and not bigger than 10000.");
                                        }
                                        else if (a + b <= c || a + c <= b || b + c <= a)
                                        {
                                            Console.WriteLine("You should input such values for the triangle's sides so the sum of any two sides of the triangle is greater than the third side.");
                                        }
                                        else
                                        {
                                            perimeter = (a + b + c) / 2.0;
                                            area = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
                                            Console.WriteLine($"Here is an area of triangle: {area}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid format. Please use digits and not any kind of symbols.");
                                    }
                                }
                                break;
                            }
                        case "square":
                            {
                                Console.Write("Please input one side of your square: ");
                                input = Console.ReadLine().Split();

                                if (Double.TryParse(input[0], out a))
                                {
                                    if (a <= 0 || a > maxValue)
                                    {
                                        Console.WriteLine("You should input positive numbers and not bigger than 10000.");
                                    }
                                    else
                                    {
                                        area = a * a;
                                        Console.WriteLine($"Here is an area of square: {area}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid format. Please use digits and not any kind of symbols.");
                                }
                                break;
                            }
                        case "rectangle":
                            {
                                Console.Write("Please input one side of your rectangle: ");
                                input = Console.ReadLine().Split();
                                if (input.Length < 2)
                                {
                                    Console.WriteLine("Too few elements. Please enter specifically two sides.");
                                }
                                else
                                {
                                    if (Double.TryParse(input[0], out a) && Double.TryParse(input[1], out b))
                                    {
                                        if (a <= 0 || b <= 0 || a > maxValue || b > maxValue)
                                        {
                                            Console.WriteLine("You should input positive numbers and not bigger than 10000.");
                                        }
                                        else
                                        {
                                            area = a * b;
                                            Console.WriteLine($"Here is an area of square: {area}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid format. Please use digits and not any kind of symbols.");
                                    }
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid input.");
                                break;
                            }
                    }
                    Console.WriteLine("Press any key to repeat. Esc - exit");
                    keyCode = Console.ReadKey();
                }


                // Delay.
                Console.ReadKey();
                return 1;
            }
        }
    }
}