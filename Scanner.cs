using System; 
using System.Collections; 
using System.Collections.Generic;

namespace rpn 
{
    public class Scanner
    {
        public static List<Operation> GetOps(string input) 
        {
            
            List<Operation> ops = new List<Operation>(); 

            // input.Trim removes trailing whitespaces. 
            // there was a bug where even a single trailing whitespace 
            // created an empty string word which caused GetToken to 
            // crash. 
            foreach(string word in input.Trim().Split(' ')){
                
                ops.Add(GetOp(word)); 
            }
            return ops; 
        }

        public static Operation GetOp(string word)
        {
            if (word == "+") {
                return new AddOperation(); 
            } else if (word == "-") {
                return new SubOperation(); 
            } else if (word == "*") {
                return new MulOperation(); 
            } else if (word == "/") {
                return new DivOperation(); 
            } else {
                double value; 
                if (Double.TryParse(word, out value)) {
                    return new NumOperation(value); 
                } else {
                    throw new InvalidSyntaxException(); 
                }
            }
        }
    }
}

