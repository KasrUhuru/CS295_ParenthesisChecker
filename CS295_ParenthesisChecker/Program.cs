using System;
using System.Collections.Generic;

namespace ParenthesisChecker
{

    public class ParenthesisChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Empty should say true: ");
            Console.WriteLine(IsBalanced(""));

            Console.Write("[{}] Should say true: ");
            Console.WriteLine(IsBalanced("[{}]"));

            Console.Write("[{}}] Should say false: ");
            Console.WriteLine(IsBalanced("[{}}]"));

            Console.Write("[{a}}] Should say false: ");
            Console.WriteLine(IsBalanced("[{a}}]"));

            // It works! Ignores non-parenthesis characters without trouble
            Console.Write("Dictionary<string, Room> Exits = new Dictionary<string, Room>() Should say true: ");
            Console.WriteLine(IsBalanced("Dictionary<string, Room> Exits = new Dictionary<string, Room>()"));

        }

        public static bool IsBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in expression)
            {
                // Empty strings are balanced
                if (c == null) { return true; }
                // Ignore non-parenthetical characters without returning false for real-world utility
                if (c != '(' || c != '[' || c != '{' || c != ')' || c != ']' || c != '}') { continue; }
                // 
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char lastIn = stack.Pop();
                    if ((c == ')' && lastIn != '(') ||
                        (c == ']' && lastIn != '[') ||
                        (c == '}' && lastIn != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
