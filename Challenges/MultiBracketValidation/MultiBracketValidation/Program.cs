using System;
using MultiBracketValidation.Classes;

namespace MultiBracketValidation
{
    public class Program
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
                    stack.Push(c);
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
        public static string GetComplimentBracket(string c)
        {
            switch(c)
            {
                case ")":
                    return "(";
                case "}":
                    return "{";
                case "]":
                    return "[";
                default:
                    return " ";
            }
        }
    
    }
}
