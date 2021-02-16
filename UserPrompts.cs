using System;

namespace EquationSolverProject
{
    class UserPrompts
    {
        public static void SelectEquation()
        {
            Console.WriteLine($"What kind of equation would you like to solve? \n Please enter a number:");
            int i = 0;
            foreach (string s in equationList[])
            {
                i++;
                Console.WriteLine($" {i}. {s}");
            }
            int userSelection = Console.ReadLine();



        }

        public static void RunAgainPrompt()
        {
            Console.WriteLine($"Would you like to do it again? Y / N");
                if (Console.ReadLine() == "Y")
                {
                    Console.WriteLine($"Let's do it again!");
                    break;
                }
                else if (Console.ReadLine() == "N")
                {
                    Console.WriteLine($"Thanks for using this program!");
                    programRunning = false;
                    
                    break;
                }
                else
                {
                    Console.WriteLine($"I don't understand.");
                }
        }
    }
}