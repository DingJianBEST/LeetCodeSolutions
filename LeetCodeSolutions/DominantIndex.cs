using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class DominantIndex
    {
        public static int DominantIndexfun(int[] nums)
        {
            int maxIndex = 0;
            for(int i = 0;i <nums.Length;i++)
            {
                if (nums[i] > nums[maxIndex])
                    maxIndex = i;
            }

            for(int index= 0;index<nums.Length;index++)
            {
                if (nums[index] == nums[maxIndex])
                    continue;
                if (nums[index] * 2 > nums[maxIndex])
                    return -1;
            }
            return maxIndex;
        }
    }
}
