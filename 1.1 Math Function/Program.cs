using System;

namespace _1._1_Math_Function
{
    class Program
    {
        static void Main()
        {
            // Introduction.
            Console.WriteLine("Task 1.1. Made by Aleksey Kharchenko.\nMy program calculates this function:\n");
            Console.WriteLine("     e^a + 4 * lg(c)                   5   ");
            Console.WriteLine("y = ---------------- * |arctg(d)| + -------");
            Console.WriteLine("         sqrt(b)                     sin(a)");
            Console.WriteLine("\n   b = 2000\n   c = 11\n   d = 27");
            Console.Write("\nPlease enter value for \"a\" =  ");


            // Calculation.
            double a = Convert.ToDouble(Console.ReadLine());
            const double b = 2000.0;
            const double c = 11.0;
            const double d = 27.0;

            double func = (Math.Exp(a) + 4 * Math.Log10(c)) / Math.Sqrt(b) * Math.Abs(Math.Atan(d)) + 5.0 / Math.Sin(a);
            Console.WriteLine($"\nThe answer is {Math.Round(func, 3)}");


            // Delay.
            Console.ReadKey();
        }
    }
}
