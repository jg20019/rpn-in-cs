using System; 
using System.Collections.Generic; 

namespace rpn
{
    public abstract class Op
    {
        public abstract void evaluate(Stack<double> stack); 
    }     
}
