using System;

namespace EquationSolverProject
{
    class LinearEquation
    {

        // y = (a * x) + b
        private int y;
        private int x = 0;
        private int a = 1;
        private int b = 0;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }

    }
}
