using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class _150_ReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "+" || tokens[i] == "-"
                    || tokens[i] == "*" || tokens[i] == "/")
                {
                    var par1 = int.Parse(stack.Pop());
                    var par2 = int.Parse(stack.Pop());
                    int res = 0;
                    switch (tokens[i])
                    {
                        case "+":
                            res = par1 + par2;
                            break;
                        case "-":
                            res = par2 - par1;
                            break;
                        case "*":
                            res = par2 * par1;
                            break;
                        case "/":
                            res = par2 / par1;
                            break;
                        default:
                            break;
                    }

                    stack.Push(res.ToString());

                    continue;
                }

                stack.Push(tokens[i]);
            }

            return int.Parse(stack.First());
        }
    }
}
