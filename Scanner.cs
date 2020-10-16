using System; 
using System.Collections.Generic;
using System.Linq; 

namespace rpn 
{
    public class Scanner
    {
        private OperationBuilder operationBuilder; 
        public Scanner(OperationBuilder builder)
        {
            operationBuilder = builder;
        }
        public IEnumerable<IOperation> GetOps(string input) =>
             input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(word => 
                operationBuilder.makeOperation(word));
    }
}

