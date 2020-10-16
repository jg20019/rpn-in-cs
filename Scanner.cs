using System; 
using System.Collections.Generic;
using System.Linq; 

namespace rpn 
{
    public class Scanner
    {
        public static IEnumerable<IOperation> GetOps(string input) => 
            input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(GetOp); 
        

        public static IOperation GetOp(string word)
        {
            return word switch 
            {
                "+" => new AddOperation(),
                "-" => new SubOperation(), 
                "*" => new MulOperation(), 
                "/" => new DivOperation(), 
                _ when double.TryParse(word, out var value) => new NumberOperation(value), 
                _ => throw new InvalidSyntaxException()
            }; 
        }
    }
}

