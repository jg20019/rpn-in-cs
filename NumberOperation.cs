using System;
using System.Collections.Generic; 

namespace rpn 
{   public class NumberOperation : IOperation 
    { 
        private double value; 

        public NumberOperation(double value) {
            this.value = value; 
        }
    
        public void Evaluate(Stack<double> stack) {
            stack.Push(value); 
        }
    }
}
    
   