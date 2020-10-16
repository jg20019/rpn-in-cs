using System;
using System.Collections.Generic; 

namespace rpn 
{   public class Num : Op
    { 
        private Double value; 

        public Num(Double value) {
            this.value = value; 
        }
    
        public override void evaluate(Stack<Double> stack) {
            stack.Push(value); 
        }
    }
}
    
   