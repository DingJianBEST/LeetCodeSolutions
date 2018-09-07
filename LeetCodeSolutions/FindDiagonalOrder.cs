using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class FindDiagonalOrder
    {
        public static int[] FindDiagonalOrderfun(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            if (m == 0 && n == 0)
                return new int[] { };

            int[] nums = new int[m * n];
            bool isUp = true;

            nums[0] = matrix[0, 0];

            int left = 0;
            int right = 0;
            for (int i = 1; i < matrix.Length; i++)
            {
                if (isUp)
                {
                    if (left == 0 || right == n - 1)
                    {
                        if(right == n - 1)
                        {
                            left += 1;
                            nums[i] = matrix[left, right];
                            isUp = false;
                            continue;
                        }

                        right += 1;
                        nums[i] = matrix[left, right];
                        isUp = false;
                        continue;
                    }

                    left -= 1;
                    right += 1;
                    nums[i] = matrix[left, right];
                }

                else
                {
                    if(right == 0 || left == m - 1)
                    {
                        if(left == m - 1)
                        {
                            right += 1;
                            nums[i] = matrix[left, right];
                            isUp = true;
                            continue;
                        }

                        left += 1;
                        nums[i] = matrix[left, right];
                        isUp = true;
                        continue;
                    }

                    left += 1;
                    right -= 1;
                    nums[i] = matrix[left, right];
                }
            }


            return nums;
        }
    }
}
