using System.Collections.Generic;

namespace rpn
{
    public class NumberOperation : IOperation
    {
        private double _value;

        public NumberOperation(double value)
        {
            _value = value;
        }

        public void Evaluate(Stack<double> stack) => 
            stack.Push(_value);
    }
}

