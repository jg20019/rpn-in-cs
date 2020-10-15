using System;

namespace rpn
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;) {
                Console.Write("> "); 
                Console.WriteLine(RPN.evaluate(Console.ReadLine())); 
            }
        }
    }
}
