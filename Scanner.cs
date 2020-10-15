using System; 
using System.Collections; 
using System.Collections.Generic;
using System.Text.RegularExpressions; 

namespace rpn 
{
    public class Scanner
    {
        public static List<Token> GetTokens(String input) 
        {
            
            List<Token> tokens = new List<Token>(); 

            // input.Trim removes trailing whitespaces. 
            // there was a bug where even a single trailing whitespace 
            // created an empty string word which caused GetToken to 
            // crash. 
            foreach(String word in Regex.Split(input.Trim(), @"\s+")){
                
                tokens.Add(GetToken(word)); 
            }
            return tokens; 
        }

        public static Token GetToken(String word)
        {
            if (word == "+") {
                return new Token(word, TokenType.ADD); 
            } else if (word == "-") {
                return new Token(word, TokenType.SUB);  
            } else if (word == "*") {
                return new Token(word, TokenType.MUL);  
            } else if (word == "/") {
                return new Token(word, TokenType.DIV);  
            } else if (IsNumber(word)) {
                return new Token(word, TokenType.NUM);  
            } else {
                throw new FormatException($"Unexpected input: '{word}'"); 
            }
        }
        private static Boolean IsNumber(String word) 
        {
            return Regex.IsMatch(word, @"^\d+$"); 
        }

    }
}

