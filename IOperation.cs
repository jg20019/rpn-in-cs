using System.Collections.Generic; 

namespace rpn
{
    public interface IOperation
    {
        void Evaluate(Stack<double> stack); 
    }     
}
