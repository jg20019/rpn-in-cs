using System; 
using System.Collections.Generic; 

namespace rpn 
{
    public class RPN 
    {
        public static double evaluate(string input) {
            Stack<double> stack  = new Stack<double>(); 
            var scanner = new Scanner(new OperationBuilder()); 
            foreach (IOperation op in scanner.GetOps(input)) 
            {
                try {
                    op.Evaluate(stack); 
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