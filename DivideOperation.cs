using System;
using System.Collections.Generic;

namespace rpn
{
    public class DivideOperation : IOperation
    {
        public void Evaluate(Stack<double> stack)
        {
            var right = stack.Pop();
            var left = stack.Pop();
            if (right == 0)
            {
                throw new DivideByZeroException();
            }
            stack.Push(left / right);
        }
    }
}