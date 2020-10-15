using Xunit;
using System; 
using System.Collections.Generic; 
using rpn; 

public class ScannerTest 
{
    [Fact]
    public void TestScanningInputWithTrailingWhiteSpace() 
    {
        // Scanner throws an exception when it is given 
        // input with trailing whitespace. 
        // "3 4 +" works. 
        // "3 4 + " threw an error.
         
        var expected = new List<Token>(); 
        expected.Add(new Token("3", TokenType.NUM));
        expected.Add(new Token("4", TokenType.NUM)); 
        expected.Add(new Token("+", TokenType.ADD)); 

        
        var tokens = Scanner.GetTokens("3 4 + ");
        Assert.Equal(expected[0], tokens[0]); 
        Assert.Equal(expected[1], tokens[1]); 
        Assert.Equal(expected[2], tokens[2]); 
        Assert.Equal(expected.Count, tokens.Count); 
    }
}
