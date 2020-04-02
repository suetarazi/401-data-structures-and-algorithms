using System;
using MultiBracketValidation.Classes;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MultiBracketValidation("input");
        }
    
    public static bool MultiBracketValidation(string input)
        {
            Stack stack = new Stack();
            string[] testString = input.Split();

            foreach(string c in testString)
            {
                if(c == "(" || c == "{" || c == "[")
                {
                    stack.Push();
                }
                else if (c == ")" || c== "}" || c == "]")
                {
                    if (stack.Peek() != GetComplimentBracket(c))
                    {
                        return false;
                    }
                    else
                        stack.Pop();
                }
            
            }
            if (stack.isEmpty())
            {
                return true;
            }
            else
                return false;
        }
        private static char GetComplimentBracket(char c)
        {
            switch(c)
            {
                case ')':
                    return '(';
                case '}':
                    return '{';
                case ']':
                    return '[';
                default:
                    return ' ';
            }
        }
    
    }
}
