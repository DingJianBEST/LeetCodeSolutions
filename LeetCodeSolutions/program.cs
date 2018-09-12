using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class program
    {
        public static void Main()
        {
            _20_IsValidbracket stack = new _20_IsValidbracket();

            string s = "()";
            string s1 = "({([])})";
            Console.WriteLine(stack.IsValid(s1));
            Console.Read();
        }
    }
}
