using System; 
using System.Collections.Generic; 

namespace rpn 
{
    public class MulOperation : Operation 
    {
        public override void evaluate(Stack<double> stack) {
            double right = stack.Pop(); 
            double left = stack.Pop(); 
            stack.Push(left * right); 
        }
    }
}