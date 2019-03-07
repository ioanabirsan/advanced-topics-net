using System;
using System.Collections.Generic;
using static System.Int32;

namespace PersonalCalculator
{
    public class ArithmeticExpression
    {
        public static int AddResults(List<string> expressions, int index)
        {
            var sum = 0;
            for (var i = 1; i <= index; i++)
            {
                sum += GetResult(expressions[i]);
            }

            return sum;
        }

        private static int GetResult(string expression)
        {
            char[] separators = new char[] {'='};
            string[] values = expression.Split(separators);

            return Parse(values[1]);
        }

        public static int ComputeResult(string expression)
        {
            char[] separators = new char[] {'+', '-', '*', '/'};
            string[] values = expression.Split(separators);
            int a = Parse(values[0]);
            int b = Parse(values[1]);

            if (expression.Contains("+"))
            {
                return a + b;
            }

            if (expression.Contains("-"))
            {
                return a - b;
            }

            if (expression.Contains("*"))
            {
                return a * b;
            }

            if (expression.Contains("/"))
            {
                return a / b;
            }

            throw new Exception("Illegal Argument");
        }
    }
}