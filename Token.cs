using System; 
using System.Collections.Generic; 

namespace rpn
{
    public enum TokenType 
    {
        ADD, SUB, MUL, DIV, 

        NUM
    } 

    public class Token : IEquatable<Token> {
        public TokenType Type { get; }
        public String Text { get; }

        public Token(String text, TokenType type) {
            Type = type; 
            Text = text; 
        } 

        public override bool Equals(Object obj)
        {
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false; 
            } else {
                return Equals((Token) obj); 
            }
        }

        public bool Equals(Token token) {
            return (Text == token.Text) && (Type == token.Type);
        }

        public override int GetHashCode()
        {
            // This is an awful way to implement GetHashCode... 
            // Tokens aren't meant to be used in Dictionaries. 
            // I just needed to implement Equals so that I 
            // could compare tokens so I could test them. 
            return 0; 
        }
    }
     
}