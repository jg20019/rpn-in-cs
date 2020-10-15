using System; 
using System.Collections.Generic; 

namespace rpn 
{
    public class RPN 
    {
        public static Double evaluate(String input) {
            Stack<Double> stack  = new Stack<Double>(); 
            foreach (Op op in Scanner.GetOps(input)) 
            {
                op.evaluate(stack); 
            }
            return stack.Peek(); 
        }
    }
}