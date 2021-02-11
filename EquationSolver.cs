using System;

namespace EquationSolverProject
{

    class EquationSolver
    {

        static void Main()
        {

            /* - Ask what type of equation to answer
             * - Enter equation
             * - Determine degree of equation, d
             * - Create containers for each value, starting d-n
             * - Array of arrays? [ax^d][bx^d-1][cx^d-2]...[px^0][q]
             * - Store data as a "history" to call upon later?
             * 
             * - Ask to either solve for input y value, or factor
             * - Start with single variable x, move on to xy later
             * - For input y, just do basic calculations and return
             * - For factoring:
             *  - Start with common factors, both numerically and with x
             *  - Remove common x first
             *  - Test a values against factors (except 1) of smallest b value, a % b == 0;
             *  - Remove largest common factor discovered
             *  - (ax) is now a factor
             * - Continue factoring until no powers remain, or it becomes unfactorable.
             *  - Get imaginary factors?
             * - Print results
             * 
             * - Ask if there are any more equations, then restart / exit
             */


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
