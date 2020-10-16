using System; 
using System.Collections.Generic; 

namespace rpn 
{
    public class DivOperation : Operation
    {
        public override void evaluate(Stack<double> stack) {
            double right = stack.Pop(); 
            double left = stack.Pop(); 
            if (right == 0) {
                throw new DivideByZeroException(); 
            }
            stack.Push(left / right); 
        }
    }
}