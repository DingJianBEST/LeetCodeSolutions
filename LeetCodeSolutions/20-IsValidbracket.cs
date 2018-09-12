using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class _20_IsValidbracket
    {
        public bool IsValid(string s)
        {
            Stack<char> bracketStack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    continue;
                
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    bracketStack.Push(s[i]);
                }
                else
                {
                    if (bracketStack.Count == 0)
                        return false;
                    if (bracketStack.First() == FindOppBracket(s[i]))
                        bracketStack.Pop();
                    else return false;
                }
            }

            if (bracketStack.Count == 0)
                return true;
            return false;
        }
        public char FindOppBracket(char bra)
        {
            switch(bra)
            {
                case '}':
                    return '{';
                case ']':
                    return '[';
                case ')':
                    return '(';
                default:
                    return ' '; 
            }
        }
    }
}
