using System;

namespace EquationSolverProject
{
    class UserPrompts
    {
        public static void EnterEquation()
        {
            // if object's bool correct == true
            // break;
            Console.WriteLine($"Please enter your equation.");
            string userEquation = Console.ReadLine();
            Console.WriteLine($"You have entered:\n{userEquation}\nis this correct? Y / N");
            string correctCheck = Console.ReadLine();
            if (correctCheck == "Y")
            {
                // Set object's bool correct = true;
                Main();
            }
            else if (correctCheck == "N")
            {
                EnterEquation();
            }
            else
            {

            }




            // Enter button
            // Check for validity of characters/equation
            // Create equation object in class
            // Send userEquation info into object
            // Sort equation info into components
            // Send error if invalid
            // Graph and factor if valid

            
        }



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