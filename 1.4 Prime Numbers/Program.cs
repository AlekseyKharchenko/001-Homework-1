using System;

namespace _1._4_Prime_Numbers
{
    class Program
    {
        static void Main()
        {
            // Introduction.
            Console.WriteLine("Task 1.4. Made by Aleksey Kharchenko.\nMy program shows all prime numbers from given range:\n");
            Console.WriteLine("Please enter range and program will show you all prime numbers inside given limits\n");

            int lowerBoundary, upperBoundary;
            int quantityOfPrimeNumbers = 0;
            int quantityOfDividers = 0;

            Console.Write("Lower boundary: ");
            lowerBoundary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Upper boundary: ");
            upperBoundary = Convert.ToInt32(Console.ReadLine());


            // Calculations.
            for (int currentNumber = lowerBoundary; currentNumber <= upperBoundary; currentNumber++)
            {
                quantityOfDividers = 0;

                for (int i = 2; i <= currentNumber / 2; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        quantityOfDividers++;
                        break;
                    }
                }

                if (quantityOfDividers == 0 && currentNumber != 1)
                {
                    Console.Write($"{currentNumber} "); // Display prime numbers if there is any.
                    quantityOfPrimeNumbers++;
                }
            }

            if (quantityOfPrimeNumbers == 0)
            {
                Console.WriteLine("There is no prime numbers in given range."); // Will be processed if there is no prime numbers were found.
            }


            // Delay.        
            Console.ReadKey();
        }
    }
}
