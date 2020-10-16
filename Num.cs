using System;
using System.Collections.Generic; 

namespace rpn 
{   public class Num : Op
    { 
        private double value; 

        public Num(double value) {
            this.value = value; 
        }
    
        public override void evaluate(Stack<double> stack) {
            stack.Push(value); 
        }
    }
}
    
   