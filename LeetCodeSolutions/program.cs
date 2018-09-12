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
            _115_MinStack stack = new _115_MinStack();

            stack.Push(0);
            stack.Push(1);
            stack.Push(0);
            Console.WriteLine(stack.GetMin());
            stack.Pop();
            Console.WriteLine(stack.GetMin());
            Console.Read();

        }
    }
}
