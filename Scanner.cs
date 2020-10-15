using System; 
using System.Collections; 
using System.Collections.Generic;
using System.Text.RegularExpressions; 

namespace rpn 
{
    public class Scanner
    {
        public static List<Op> GetOps(String input) 
        {
            
            List<Op> ops = new List<Op>(); 

            // input.Trim removes trailing whitespaces. 
            // there was a bug where even a single trailing whitespace 
            // created an empty string word which caused GetToken to 
            // crash. 
            foreach(String word in Regex.Split(input.Trim(), @"\s+")){
                
                ops.Add(GetOp(word)); 
            }
            return ops; 
        }

        public static Op GetOp(String word)
        {
            if (word == "+") {
                return new AddOp(); 
            } else if (word == "-") {
                return new SubOp(); 
            } else if (word == "*") {
                return new MulOp(); 
            } else if (word == "/") {
                return new DivOp(); 
            } else if (IsNumber(word)) {
                return new Num(Double.Parse(word)); 
            } else {
                throw new InvalidSyntaxException(); 
            }
        }
        private static Boolean IsNumber(String word) 
        {
            return Regex.IsMatch(word, @"^\d+$"); 
        }

    }
}

