using System;
using System.Diagnostics;

namespace _2._4_Guess_The_Number
{
    class Program
    {
        static void Main()
        {
            string[] input;

            int[] array;
            int lowerLimit = 0;
            int upperLimit = 0;
            int arrSize = 0;

            int unsuccessfulTries = 0;
            int cpuChoice;
            int playerChoice;

            bool isSurrendered = false;

            Random r = new Random();

            var sw = Stopwatch.StartNew();

            // Introduction.
            Console.WriteLine($"Task 2.4. Made by Aleksey Kharchenko.");
            Console.WriteLine("Play the game where you should guess the number from the input range [0 - 1,000,000]:");
            Console.WriteLine($"Perfect quess is {CalculatePoints(8, 2)} points.");

            // Inputing range.
            do
            {
                try
                {
                    Console.WriteLine("\n\nPlease simultaneously enter the lower and upper limits for range: ");
                    input = Console.ReadLine().Split();

                    lowerLimit = int.Parse(input[0]);
                    upperLimit = int.Parse(input[1]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please try using digits and not any kind of symbols.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Please enter two numbers for chosen range.");
                }
                if (lowerLimit < 0 || upperLimit <= 0 || lowerLimit >= upperLimit)
                {
                    Console.WriteLine("Incorrect input. Please enter non-negative numbers and note that lower limit should be strictly less than upper limit.");
                }
            } while (lowerLimit < 0 || upperLimit <= 0 || lowerLimit >= upperLimit);


            // Creating of array
            arrSize = upperLimit - lowerLimit + 1;
            array = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                array[i] = lowerLimit + i;
            }

            cpuChoice = array[r.Next(arrSize)]; // CPU makes it's choice
            Console.WriteLine($"CPUCHOICE - {cpuChoice}");

            do
            {
                Console.WriteLine($"\nPlease enter numbers from [{lowerLimit}, {upperLimit}] or type \"Exit\" to give up.");
                input = Console.ReadLine().ToLower().Split();

                if (input[0] == "exit")
                {
                    Console.WriteLine($"\nIt is too bad that you go so early...");
                    isSurrendered = true;
                    ShowStatistics(cpuChoice, unsuccessfulTries, arrSize, isSurrendered, sw);
                    Console.ReadKey();
                    return;
                }
                if (int.TryParse(input[0], out playerChoice) && playerChoice >= lowerLimit && playerChoice <= upperLimit)
                {
                    if (playerChoice < cpuChoice) { Console.WriteLine("Too few!"); unsuccessfulTries++; }
                    if (playerChoice > cpuChoice) { Console.WriteLine("Too much!"); unsuccessfulTries++; }
                }
                else
                {
                    Console.WriteLine($"Incorrect input. Please try using non-negative numbers in range [{lowerLimit}, {upperLimit}].");
                }
                if (playerChoice == cpuChoice)
                {
                    Console.Write("\nCongratulations! ");
                }
            } while (playerChoice != cpuChoice);


            // Display all information about game; 
            ShowStatistics(cpuChoice, unsuccessfulTries, arrSize, isSurrendered, sw);


            // Delay.
            Console.ReadKey();
        }
        static double CalculatePoints(int allPossibleAnswers, int unsuccessfulTries)
        {
            double score = 0.0;
            int pow = 0;

            while (allPossibleAnswers > 0)
            {
                allPossibleAnswers >>= 1;
                pow++;
            }
            pow--;

            if (pow <= unsuccessfulTries)
            {
                return score;
            }
            else
            {
                score = 100 * (pow - unsuccessfulTries) / pow;
                return Math.Round(score);
            }
        }
        static void ShowStatistics(int cpuChoice, int unsuccessfulTries, int arrSize, bool isSurrendered, Stopwatch sw)
        {
            Console.WriteLine($"The secret number was {cpuChoice}");
            Console.WriteLine($"Your quantity of tries is {unsuccessfulTries + 1}");
            if (isSurrendered == false)
            {
                Console.WriteLine($"Your score is {CalculatePoints(arrSize, unsuccessfulTries)} points.");
            }
            else
            {
                Console.WriteLine("Your score is 0 points.");
            }
            Console.WriteLine($"Your playing time is {sw.Elapsed}");

        }
    }
}
