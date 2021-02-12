using System;

namespace EquationSolverProject
{
    class SolveLinear
    {
        public static void LinearEquation()
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
        }



        
    }
}