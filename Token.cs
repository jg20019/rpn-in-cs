using System; 

namespace rpn
{
    public enum TokenType 
    {
        ADD, SUB, MUL, DIV, 

        NUM
    } 

    public class Token {
        public TokenType Type { get; }
        public String Text { get; }

        public Token(String text, TokenType type) {
            Type = type; 
            Text = text; 
        } 
    }
     
}