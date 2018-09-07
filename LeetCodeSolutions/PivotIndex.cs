using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class PivotIndex
    {
        public static int PivotIndexs(int[] nums)
        {
            
            for (int i =0;i<nums.Length;i++)
            {
                int num1 = 0;
                int num2 = 0;

                for (int j = 0;j <i;j++)
                {
                    num1 += nums[j];
                }

                for(int k = nums.Length -1;k >i;k--)
                {
                    num2 += nums[k];
                }

                if (num1 == num2)
                    return i;
            }

            return -1;
        }
    }
}
