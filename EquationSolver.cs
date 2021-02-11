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
                Console.WriteLine($"Let's do a linear equation!");

                LinearEquation myEqu = new LinearEquation();

                Console.WriteLine($"Please enter your a value:");
                string inputA = Console.ReadLine();
                if (CheckIfNumber(inputA))
                {
                    myEqu.A = ConvertToNumber(inputA);
                }

                Console.WriteLine($"Please enter your b value:");
                string inputB = Console.ReadLine();
                if (CheckIfNumber(inputB))
                {
                    myEqu.B = ConvertToNumber(inputB);
                }

                Console.WriteLine($"Please enter your x value:");
                string inputX = Console.ReadLine();
                if (CheckIfNumber(inputX))
                {
                    myEqu.X = ConvertToNumber(inputX);
                }

                Console.WriteLine($"Your equation is:");
                Console.WriteLine($" y = {myEqu.A} * {myEqu.X} + {myEqu.B}");
                Console.WriteLine($"Is this correct? Y / N");

                bool answerGiven = false;
                while (answerGiven == false)
                {
                    if (Console.ReadLine() == "Y")
                    {
                        myEqu.Y = MathOperations.SolveForY(myEqu.A, myEqu.X, myEqu.B);
                        Console.WriteLine($"Your answer is y = {myEqu.Y}");
                        answerGiven = true;
                    }
                    else if (Console.ReadLine() == "N")
                    {
                        Console.WriteLine($"Oops! Let's fix that.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"I don't understand.");
                    }
                }

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
