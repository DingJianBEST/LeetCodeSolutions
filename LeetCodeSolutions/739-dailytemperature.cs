using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class _739_dailytemperature
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] res = new int[temperatures.Length];

            Stack<int> record = new Stack<int>();
            for (int i = 0; i < temperatures.Length; i++)
            {
                while (record.Count > 0 &&
                    temperatures[record.Peek()] < temperatures[i])
                {
                    int index = record.Pop();
                    res[index] = i - index;
                }

                record.Push(i);
            }

            return res;
        }
    }
}
