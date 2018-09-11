using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class _622_MyCircularQueue
    {
        private int[] queue;
        private int size = 0;
        private int front = -1;
        private int rear = -1;

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public _622_MyCircularQueue(int k)
        {
            queue = new int[k];
            size = k;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull())
                return false;
            else if (IsEmpty())
            {
                front = 0;
            }
            rear = (rear + 1) % size;
            queue[rear] = value;

            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty())
                return false;
            else
            {
                queue[front] = 0;

                if (front == rear)
                {
                    front = -1;
                    rear = -1;
                }
                else
                    front = (front + 1) % size;

            }
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (front == -1)
                return -1;
            return queue[front];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (rear == -1)
                return -1;
            return queue[rear];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            if (front == -1 && rear == -1)
                return true;
            return false;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            if ((rear + 1) % size == front)
                return true;
            return false;
        }
    }
}
