using System; 
using System.Collections.Generic; 

namespace rpn
{
    public abstract class Operation
    {
        public abstract void evaluate(Stack<double> stack); 
    }     
}
