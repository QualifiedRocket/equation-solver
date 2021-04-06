using System;

namespace EquationSolverProject
{

    class EquationSolver
    {

        static void Main()
        {

            bool programRunning = true;
            while (programRunning)
            {
                
                EnterEquation();
                EquationObject userEquation = new EquationObject();
                ReadEquation();
                RunAgainPrompt(); // Replace with exit command later

            }
        }

        static bool CheckIfNumber(string word)
        {
            if (int.TryParse(word, out int number))
            {
                Console.WriteLine($"You entered {word}. It can be converted to {number}.");
                return true;
            }
            Console.WriteLine($"You entered {word}. It cannot be converted.");
            return false;
        }

        static int ConvertToNumber(string word)
        {
            int.TryParse(word, out int number);
            return number;
        }
    }
}
