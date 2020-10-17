﻿using System;

namespace rpn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RPN Calculator"); 
            Console.WriteLine("Type Ctrl + c to exit."); 
            var builder = new OperationBuilder();
            var rpn = new RPNEvaluator(new Scanner(builder)); 
            while(true)
            {
                try
                { 
                    Console.Write("> "); 
                    Console.WriteLine(rpn.evaluate(Console.ReadLine())); 
                }
                catch (InvalidSyntaxException e)
                {
                    Console.WriteLine(e.Message); 
                } catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero."); 
                }
            }
        }
    }
}
