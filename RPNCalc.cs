using System; 
using System.Collections.Generic; 

namespace rpn 
{
    public class RPN 
    {
        public static Double evaluate(String input) {
            Stack<Double> stack  = new Stack<Double>(); 
            Double right;
            Double left; 
            foreach (Token token in Scanner.GetTokens(input)) 
            {
                switch (token.Type) {
                    case TokenType.ADD: 
                        right = stack.Pop(); 
                        left = stack.Pop(); 
                        stack.Push(left + right); 
                        break; 

                    case TokenType.SUB: 
                        right = stack.Pop(); 
                        left = stack.Pop(); 
                        stack.Push(left - right); 
                        break; 

                    case TokenType.MUL: 
                        right = stack.Pop(); 
                        left = stack.Pop(); 
                        stack.Push(left * right); 
                        break; 

                    case TokenType.DIV: 
                        right = stack.Pop(); 
                        left = stack.Pop(); 
                        stack.Push(left / right); 
                        break; 

                    case TokenType.NUM: 
                        stack.Push(Double.Parse(token.Text)); 
                        break; 
                }
            }
            return stack.Peek(); 
        }
    }
}