using System; 
using System.Collections; 
using System.Collections.Generic;

namespace rpn 
{
    public class Scanner
    {
        public static List<Op> GetOps(string input) 
        {
            
            List<Op> ops = new List<Op>(); 

            // input.Trim removes trailing whitespaces. 
            // there was a bug where even a single trailing whitespace 
            // created an empty string word which caused GetToken to 
            // crash. 
            foreach(string word in input.Trim().Split(' ')){
                
                ops.Add(GetOp(word)); 
            }
            return ops; 
        }

        public static Op GetOp(string word)
        {
            if (word == "+") {
                return new AddOp(); 
            } else if (word == "-") {
                return new SubOp(); 
            } else if (word == "*") {
                return new MulOp(); 
            } else if (word == "/") {
                return new DivOp(); 
            } else {
                double value; 
                if (Double.TryParse(word, out value)) {
                    return new Num(value); 
                } else {
                    throw new InvalidSyntaxException(); 
                }
            }
        }
    }
}

