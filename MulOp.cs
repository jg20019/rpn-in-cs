using System.Collections.Generic;

namespace rpn
{
    public class MultiplicationOperation : IOperation
    {
        public void Evaluate(Stack<double> stack)
        {
            var right = stack.Pop();
            var left = stack.Pop();
            stack.Push(left * right);
        }
    }
}