using System; 
using System.Collections.Generic; 

namespace rpn 
{
    public class DivOperation : IOperation
    {
        public void Evaluate(Stack<double> stack) {
            double right = stack.Pop(); 
            double left = stack.Pop(); 
            if (right == 0) {
                throw new DivideByZeroException(); 
            }
            stack.Push(left / right); 
        }
    }
}