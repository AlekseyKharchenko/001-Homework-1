using System;

namespace _2._1_Rock_Paper_Scissors
{
    class Program
    {
        static void Main()
        {
            // Introduction.
            Console.WriteLine("Task 2.1. Made by Aleksey Kharchenko.");
            Console.WriteLine("Play in legendary \"Rock Paper Scissors\" game with my program:\n");

            Console.WriteLine("You have to enter one of given commands: rock, paper, scissors (non case-sensitive).");
            Console.WriteLine("Then computer will give his variant and then it will tell you who is a winner.");
            Console.WriteLine("Rules are pretty simple:");
            Console.WriteLine("Rock beats scissors, scissors cuts paper, paper covers rock. If both shapes are the same then the game is tied.");


            // Processing inputs.
            ConsoleKeyInfo keyCode = new ConsoleKeyInfo();

            string[] cpuPossibleAnswers = { "rock", "scissors", "paper" };
            int totalRounds = 0;
            int playerVictories = 0;
            int cpuVictories = 0;

            while (keyCode.Key != ConsoleKey.Escape)
            {
                totalRounds++;
                Console.WriteLine("\n\nDo you choose rock, paper or scissors?");
                string playerChoice = Console.ReadLine().ToLower();
                Random rand = new Random();
                int i = rand.Next(3);

                switch (playerChoice)
                {
                    case "rock":
                        if (cpuPossibleAnswers[i] == "rock")
                        {
                            Console.WriteLine("\nThe computer has chosen rock");
                            Console.WriteLine("Tie...");
                        }
                        if (cpuPossibleAnswers[i] == "scissors")
                        {
                            playerVictories++;
                            Console.WriteLine("\nThe computer has chosen scissors");
                            Console.WriteLine("You won...");
                        }
                        if (cpuPossibleAnswers[i] == "paper")
                        {
                            cpuVictories++;
                            Console.WriteLine("\nThe computer has chosen paper");
                            Console.WriteLine("You lost...");
                        }
                        break;

                    case "scissors":
                        if (cpuPossibleAnswers[i] == "rock")
                        {
                            cpuVictories++;
                            Console.WriteLine("\nThe computer has chosen rock");
                            Console.WriteLine("You lost...");
                        }
                        if (cpuPossibleAnswers[i] == "scissors")
                        {
                            Console.WriteLine("\nThe computer has chosen scissors");
                            Console.WriteLine("Tie...");
                        }
                        if (cpuPossibleAnswers[i] == "paper")
                        {
                            playerVictories++;
                            Console.WriteLine("\nThe computer has chosen paper");
                            Console.WriteLine("You won...");
                        }
                        break;

                    case "paper":
                        if (cpuPossibleAnswers[i] == "rock")
                        {
                            playerVictories++;
                            Console.WriteLine("\nThe computer has chosen rock");
                            Console.WriteLine("You won...");
                        }
                        if (cpuPossibleAnswers[i] == "paper")
                        {
                            Console.WriteLine("\nThe computer has chosen paper");
                            Console.WriteLine("Tie...");
                        }
                        if (cpuPossibleAnswers[i] == "scissors")
                        {
                            cpuVictories++;
                            Console.WriteLine("\nThe computer has chosen scissors");
                            Console.WriteLine("You lost..");
                        }
                        break;

                    default:
                        {
                            totalRounds--;
                            Console.WriteLine("\nYou incorrectly typed in word. Please try again.");
                            Console.WriteLine("Possible answers: rock, paper or scissors");
                        }
                        break;
                }
                Console.WriteLine("Press any key to repeat. Esc - exit");
                keyCode = Console.ReadKey();
            }


            // Statistics.
            Console.WriteLine("Thank you for palying!");
            Console.WriteLine("Here is your statistic:");
            Console.WriteLine($"\tTotal rounds: {totalRounds}");
            Console.WriteLine($"\tTimes you won: {playerVictories}");
            Console.WriteLine($"\tTimes you lost: {cpuVictories}");
            Console.WriteLine($"\tTimes tie occured: {totalRounds - playerVictories - cpuVictories}");


            // Delay.
            Console.ReadKey();
        }
    }
}
