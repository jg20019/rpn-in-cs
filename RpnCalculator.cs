using System;
using System.Collections.Generic;

namespace rpn
{
    public class RpnCalculator
    {
        public static double Evaluate(string input)
        {
            var stack = new Stack<double>();
            try
            {
                foreach (var operation in Scanner.GetOperations(input))
                {
                    operation.Evaluate(stack);
                }
            }
            catch (InvalidOperationException)
            {
                throw InvalidSyntax();
            }

            if (stack.Count != 1)
            {
                throw InvalidSyntax();
            }
            return stack.Peek();

            InvalidSyntaxException InvalidSyntax() => new InvalidSyntaxException($"Invalid syntax: '{input}'");
        }
    }
}