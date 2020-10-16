using System;
using System.Collections.Generic; 

namespace rpn 
{   public class NumOperation : Operation 
    { 
        private double value; 

        public NumOperation(double value) {
            this.value = value; 
        }
    
        public override void evaluate(Stack<double> stack) {
            stack.Push(value); 
        }
    }
}
    
   