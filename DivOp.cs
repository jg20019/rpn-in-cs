using System; 
using System.Collections.Generic; 

namespace rpn 
{
    public class DivOp : Op
    {
        public override void evaluate(Stack<Double> stack) {
            Double right = stack.Pop(); 
            Double left = stack.Pop(); 
            if (right == 0) {
                throw new DivideByZeroException(); 
            }
            stack.Push(left / right); 
        }
    }
}