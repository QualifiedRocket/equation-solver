using System;

namespace EquationSolverProject
{
    public static class MathOperations
    {

        // Basic Math

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Rem(int num1, int num2)
        {
            return num1 % num2;
        }


        // Solve for _

        public static int SolveForY(int a, int x, int b)
        {
            int y = (a * x) + b;
            return y;
        }

    }
}