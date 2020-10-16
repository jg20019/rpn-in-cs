using System.Collections.Generic; 

namespace rpn 
{
    public class MultiplicationOperation : IOperation 
    {
        public void Evaluate(Stack<double> stack)
        {
            double right = stack.Pop(); 
            double left = stack.Pop(); 
            stack.Push(left * right); 
        }
    }
}