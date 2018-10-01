using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {
        }
        public int Add(int x, int b)
        {
            return x + b;
        }

        public int Divide(int x, int b )
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero");
            return x/b;
        }



        public int Multiply(int x, int b)
        {
            return x * b;
        }


        public int Substract(int x, int b)
        {
            return x - b;
        }
    }
}
