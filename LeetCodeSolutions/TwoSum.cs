using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class TwoSum
    {
        public static int[] TwoSums(int[] numbers, int target)
        {

            //由于数组是有序的，采取两端逼近的办法解决

            int min = 0;

            int max = numbers.Length - 1;

            while (true)
            {
                if (numbers[min] + numbers[max] == target)
                {
                    return new int[] { min + 1, max + 1 };
                }
                if (numbers[min] + numbers[max] > target)
                    max--;
                else
                    min++;
            }
        }
    }
}
