using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class _115_MinStack
    {
        Stack<int> numStack;
        Stack<int> minStack;

        /** initialize your data structure here. */
        public _115_MinStack()
        {
            numStack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int x)
        {
            if (numStack.Count == 0 || x <= minStack.First())
            {
                numStack.Push(x);
                minStack.Push(x);
            }
            else
                numStack.Push(x);
        }

        public void Pop()
        {
            if (numStack.Count == 0)
                return;

            else if (numStack.First() == minStack.First())
            {
                minStack.Pop();
            }

            numStack.Pop();
        }

        public int Top()
        {
            if (numStack.Count == 0)
                return -1;
            return numStack.FirstOrDefault();
        }

        public int GetMin()
        {
            if (numStack.Count == 0)
                return -1;
            return minStack.First();
        }
    }
}
