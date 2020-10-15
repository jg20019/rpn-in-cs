using System;

namespace rpn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RPN Calculator"); 
            Console.WriteLine("Type Ctrl + c to exit."); 
            for(;;) {
                try{ 
                    Console.Write("> "); 
                    Console.WriteLine(RPN.evaluate(Console.ReadLine())); 
                } catch (InvalidSyntaxException e) {
                    Console.WriteLine(e.Message); 
                } catch (DivideByZeroException) {
                    Console.WriteLine("Cannot divide by zero."); 
                }
            }
        }
    }
}
