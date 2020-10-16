using System; 
using System.Collections.Generic; 

namespace rpn 
{
    public class MulOperation : IOperation 
    {
        public void Evaluate(Stack<double> stack) {
            double right = stack.Pop(); 
            double left = stack.Pop(); 
            stack.Push(left * right); 
        }
    }
}