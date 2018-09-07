using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class FindThePeakNum
    {
        public int FindPeakElement(int[] nums)
        {
            int begin = 0;
            int end = nums.Length - 1;
            while (begin < end)
            {
                int mid = begin + (end - begin) / 2;

                if (mid == 0)
                {
                    if (nums[mid] > nums[mid + 1])
                        return 0;
                    else return 1;
                }
                if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
                {
                    return mid;
                }

                else if (nums[mid] < nums[mid - 1])
                {
                    end = mid - 1;
                }

                else
                {
                    begin = mid + 1;
                }
            }

            return begin;
        }
    }
}
