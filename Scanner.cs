using System;
using System.Collections.Generic;
using System.Linq;

namespace rpn
{
    public class Scanner
    {
        public static IEnumerable<IOperation> GetOperations(string input) =>
            input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(GetOp);

        public static IOperation GetOp(string word)
        {
            return word switch 
            {
                "+" => new AddOperation(),
                "-" => new SubtractOperation(),
                "*" => new MultiplicationOperation(),
                "/" => new DivideOperation(),
                _ when double.TryParse(word, out var value) => new NumberOperation(value),
                _ => throw new InvalidSyntaxException()
            };
        }
    }
}