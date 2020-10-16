using System; 
using System.Collections.Generic; 

namespace rpn 
{
    public class RPN 
    {
        public static Double evaluate(String input) {
            Stack<Double> stack  = new Stack<Double>(); 
            try {
                List<Op> ops = Scanner.GetOps(input); 
            } catch (InvalidSyntaxException) {
                throw new InvalidSyntaxException($"Invalid syntax: '{input}'"); 
            }
            foreach (Op op in Scanner.GetOps(input)) 
            {
                try {
                    op.evaluate(stack); 
                } catch (InvalidOperationException) {
                    throw new InvalidSyntaxException($"Invalid syntax: '{input}'"); 
                }
            }

            if (stack.Count !=1 ){
                throw new InvalidSyntaxException($"Invalid syntax: '{input}'"); 
            }
            return stack.Peek(); 
        }
    }
}