using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class FindMinInSortedArray
    {
        public static int FindMin(int[] nums)
        {
            int begin = 0;
            int end = nums.Length - 1;
            while (begin < end - 1)
            {
                int mid = begin + (end - begin) / 2;
                if (nums[mid] < nums[end])
                    end = mid;
                else if (nums[mid] > nums[end])
                    begin = mid;

            }

            return nums[begin] < nums[end] ? nums[begin] : nums[end];
        }
    }
}
