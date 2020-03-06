using System;
using System.Collections.Generic;

namespace StackPostfix
{
    class Program
    {

        internal static int Precendence(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;

            }

            return -1;
        }
        public static string infixToPostfix(string exp)
        {
            string result = "";

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < exp.Length; ++i)
            {
                char c = exp[i];
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result += stack.Pop();
                    }
                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        return "Invalid expression";
                    }
                    else
                    {
                        stack.Pop();
                    }

                }
                else
                {
                    while (stack.Count > 0 && Precendence(c) <= Precendence(stack.Peek()))
                    {
                        result += stack.Pop();
                    }
                    stack.Push(c);
                }


            }

            while (stack.Count > 0)
            {
                result += stack.Pop();
            }
            return result;
        }
        
        static void Main(string[] args)
        {
            //string exp = "a+b*(c^d-e)^(f+g*h)-i";
            string exp="a+b*c+d";
            Console.WriteLine(infixToPostfix(exp));
        }
    }
}
