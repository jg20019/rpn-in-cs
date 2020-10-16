using System; 
using System.Collections.Generic; 

namespace rpn 
{
    public class AddOp : Op 
    {
        public override void evaluate(Stack<Double> stack) {
            Double right = stack.Pop(); 
            Double left = stack.Pop(); 
            stack.Push(left + right); 
        }
    }
}