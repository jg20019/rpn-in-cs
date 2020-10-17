using System; 
using System.Collections.Generic; 

namespace rpn 
{

     
    public class RPNEvaluator 
    {
        private Scanner _scanner; 
        public RPNEvaluator(Scanner scanner)
        {
            _scanner = scanner; 
        }
        public double evaluate(string input)
        {
            Stack<double> stack  = new Stack<double>(); 
            foreach (IOperation op in _scanner.GetOps(input)) 
            {
                try 
                {
                    op.Evaluate(stack); 
                } catch (InvalidOperationException)
                {
                    throw new InvalidSyntaxException($"Invalid syntax: '{input}'"); 
                }
            }

            if (stack.Count != 1)
            {
                throw new InvalidSyntaxException($"Invalid syntax: '{input}'"); 
            }
            return stack.Peek(); 
        }
    }
}