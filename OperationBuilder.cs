using System;

namespace rpn 
{
    public class OperationBuilder 
    {
        public IOperation makeOperation(string word)
        {
            return word switch
            {
                "+" => new AdditionOperation(),
                "-" => new SubtractionOperaton(), 
                "*" => new MultiplicationOperation(), 
                "/" => new DivideOperation(), 
                _ when double.TryParse(word, out var value) => new NumberOperation(value), 
                _ => throw new InvalidSyntaxException()
            };
        }
    }
}