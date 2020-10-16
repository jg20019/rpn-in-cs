using System; 
using System.Collections.Generic; 

namespace rpn 
{
 public class SubOp : Op 
    {
        public override void evaluate(Stack<Double> stack) {
            Double right = stack.Pop(); 

            // if there were only 1 value on the stack, negate it
            if (stack.Count == 0) {
                stack.Push(-1 * right); 
            } else {
                Double left = stack.Pop(); 
                stack.Push(left - right);  
            }

        }
    }
}