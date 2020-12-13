using System;

namespace _1._2_Margin_Calculation
{
    class Program
    {
        static void Main()
        {
            // Introduction.
            Console.WriteLine("Task 1.2. Made by Aleksey Kharchenko.\nMy program calculates margin from given odds for V1, X, V2:\n");

            Console.WriteLine("Please enter names of both teams.");
            Console.Write("First team name: ");
            string teamName1 = Console.ReadLine();
            Console.Write("Second team name: ");
            string teamName2 = Console.ReadLine();

            Console.WriteLine("\nNow please enter odds for Victory of the 1st team, Draw and Victory for the 2nd team:");
            Console.Write("V1: ");
            double firstVictoryOdds = Convert.ToDouble(Console.ReadLine());
            Console.Write("X: ");
            double drawOdds = Convert.ToDouble(Console.ReadLine());
            Console.Write("V2: ");
            double secondVictoryOdds = Convert.ToDouble(Console.ReadLine());


            // Calculation of margin.
            double margin = 100.0 - 100.0 / (1.0 / firstVictoryOdds + 1.0 / drawOdds + 1.0 / secondVictoryOdds);
            double firstVictoryPercent = Math.Round(100.0 / firstVictoryOdds, 1);
            double secondVictoryPercent = Math.Round(100.0 / secondVictoryOdds, 1);

            Console.WriteLine("\nHere is probabilites of each outcome:");
            Console.WriteLine($"{teamName1}'s victory chance: {firstVictoryPercent}%");
            Console.WriteLine($"{teamName2}'s victory chance: {secondVictoryPercent}%");
            Console.WriteLine($"Draw chance: {100.0 - firstVictoryPercent - secondVictoryPercent:0.0}%");
            Console.WriteLine($"Margin: {Math.Round(margin, 1)}%");


            // Delay.
            Console.ReadKey();
        }
    }
}
