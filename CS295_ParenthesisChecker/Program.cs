using System;
using System.Collections.Generic;

namespace ParenthesisChecker
{

    public class ParenthesisChecker
    {
    static void Main(string[] args)
    {
        Console.Write("Should say true: ");
        Console.WriteLine(IsBalanced("[{}]"));
        Console.Write("Should say false: ");
        Console.WriteLine(IsBalanced("[{}}]"));
    }
        public static bool IsBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in expression)
            {
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

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
