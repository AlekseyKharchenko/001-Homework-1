using System;

namespace _1._3_Series_Sum
{
    class Program
    {
        static void Main()
        {
            // Introduction.
            Console.WriteLine("Task 1.3. Made by Aleksey Kharchenko.\nMy program calculates given series sum:\n");
            Console.WriteLine("Precision is 1/2000 (0.0005)");
            Console.WriteLine("     oo           ");
            Console.WriteLine("    ----          ");
            Console.WriteLine("    \\        1   ");
            Console.WriteLine("y = /    ---------");
            Console.WriteLine("    ----  i*(i+1) ");
            Console.WriteLine("     i=1          ");

            double eps = 5e-4; // The same as 0.0005
            double totalSum = 0;
            double iterationSum;
            int i = 1;


            // Calculations.
            do
            {
                iterationSum = 1.0 / (i * (i + 1));
                totalSum += iterationSum;
                i++;
            } while (iterationSum >= eps);

            Console.WriteLine($"\nProgram has reached the result with given precision on its {i}-st iteration.");
            Console.WriteLine($"y = {totalSum:0.0000}");

            // Delay.        
            Console.ReadKey();
        }
    }
}
