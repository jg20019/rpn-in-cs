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

    public class InvalidSyntaxException : System.Exception
    {
        public InvalidSyntaxException() : base() {}
        public InvalidSyntaxException(string message) : base(message) {}
        public InvalidSyntaxException(string message, System.Exception inner) : base(message, inner) {}

        protected InvalidSyntaxException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}