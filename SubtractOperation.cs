using System.Collections.Generic;

namespace rpn
{
    public class SubtractOperation : IOperation
    {
        public void Evaluate(Stack<double> stack)
        {
            var right = stack.Pop();

            // if there were only 1 value on the stack, negate it
            if (stack.Count == 0)
            {
                stack.Push(-1 * right);
            }
            else
            {
                var left = stack.Pop();
                stack.Push(left - right);
            }

        }
    }
}