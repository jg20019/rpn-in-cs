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

            foreach(String word in Regex.Split(input, @"\s+")){
                if (word == "+") {
                    tokens.Add(new Token(word, TokenType.ADD)); 
                } else if (word == "-") {
                    tokens.Add(new Token(word, TokenType.SUB)); 
                } else if (word == "*") {
                    tokens.Add(new Token(word, TokenType.MUL)); 
                } else if (word == "/") {
                    tokens.Add(new Token(word, TokenType.DIV)); 
                } else if (IsNumber(word)) {
                    tokens.Add(new Token(word, TokenType.NUM)); 
                } else {
                    Console.WriteLine($"Unexpected input: '{word}'"); 
                    Environment.Exit(65); 
                }
            }
            return tokens; 
        }

        private static Boolean IsNumber(String word) 
        {
            return Regex.IsMatch(word, @"^\d+$"); 
        }

    }
}

