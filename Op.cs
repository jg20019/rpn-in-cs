using System; 
using System.Collections.Generic; 

namespace rpn
{
    public abstract class Op
    {
        public abstract void evaluate(Stack<Double> stack); 
    }
    
    public class Num : Op
    { 
        private Double value; 

        public Num(Double value) {
            this.value = value; 
        }
    
        public override void evaluate(Stack<Double> stack) {
            stack.Push(value); 
        }
    }
    
    public class AddOp : Op 
    {
        public override void evaluate(Stack<Double> stack) {
            Double right = stack.Pop(); 
            Double left = stack.Pop(); 
            stack.Push(left + right); 
        }
    }

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

    public class MulOp : Op 
    {
        public override void evaluate(Stack<Double> stack) {
            Double right = stack.Pop(); 
            Double left = stack.Pop(); 
            stack.Push(left * right); 
        }
    }

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
