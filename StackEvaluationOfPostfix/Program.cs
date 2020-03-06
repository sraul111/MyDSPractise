using System;
using System.Collections.Generic;

namespace StackEvaluationOfPostfix
{

    class EvaluateExpression
    {
        int Divide(int a, int b)
        {
            return a / b;
        }
        int Multiply(int a, int b)
        {
            return a * b;
        }

        int Add(int a, int b)
        {
            return a + b;
        }

        int Substract(int a, int b)
        {
            return a - b;
        }

        internal int EvaluateMathematicalExpressionUsingStack(string expression)
        {
            int result = 0, a = 0, b = 0;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expression.Length; ++i)
            {
                string subs = expression.Substring(i,1);
                var isNumeric = int.TryParse(subs,out int n);

                if (isNumeric)
                {
                    stack.Push(Convert.ToInt32(subs));
                    continue;
                }
                else if (subs.Equals("+"))
                {
                    if (stack.Count > 0)
                    {
                        a = stack.Pop();
                    }
                    if (stack.Count > 0)
                    {
                        b = stack.Pop();
                    }
                  // int result = Add(a, b);
                    stack.Push(Add(a,b));
                   a=0;b=0; 
                    continue;

                }
                else if (subs.Equals("-"))
                {
                    if (stack.Count > 0) { a = (int)stack.Pop(); }
                    if (stack.Count > 0) { b = (int)stack.Pop(); }
                    //result = Substract(a, b);
                    stack.Push(Substract(a,b));
                    a=0;b=0;
                    continue;
                }
                else if (subs.Equals("*"))
                {
                    if (stack.Count > 0) { a = (int)stack.Pop(); }
                    if (stack.Count > 0) { b = (int)stack.Pop(); }
                    // result = Multiply(a, b);
                    stack.Push(Multiply(a,b));
                    a=0;b=0;
                    continue;
                }
                else if (subs.Equals("/"))
                {
                    if (stack.Count > 0) { a = (int)stack.Pop(); }
                    if (stack.Count > 0) { b = (int)stack.Pop(); }
                    result = Divide(a, b);
                    stack.Push(result);
                    a=0;b=0;
                    continue;
                }


            }

            return stack.Pop();

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            EvaluateExpression ee = new EvaluateExpression();
            int result = ee.EvaluateMathematicalExpressionUsingStack("231*+9-");
            Console.Write(" Evaluation of the expression is {0}", result);
        }
    }
}
