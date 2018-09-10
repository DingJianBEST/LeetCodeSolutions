using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class _54_SpiralOrder
    {
        public static int[] SpiralOrder(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            if (m == 0 && n == 0)
                return new int[] { };

            //right 0, down 1, left 2, up 3
            int dir = 0;
            int[] nums = new int[matrix.Length];
            int[,] flags = new int[m, n];
            nums[0] = matrix[0, 0];
            flags[0, 0] = 1;

            int row = 0;
            int column = 0;
            for (int i = 1; i < matrix.Length; i++)
            {
                if (dir == 0)
                {
                    if (column == n - 1 || flags[row, column + 1] == 1)
                    {
                        row += 1;
                        nums[i] = matrix[row, column];
                        flags[row, column] = 1;
                        dir = 1;
                        continue;
                    }

                    column += 1;
                    nums[i] = matrix[row, column];
                    flags[row, column] = 1;
                    continue;
                }

                if(dir == 1)
                {
                    if(row == m-1 || flags[row+1,column] == 1)
                    {
                        column -= 1;
                        nums[i] = matrix[row, column];
                        flags[row, column] = 1;
                        dir = 2;
                        continue;
                    }

                    row += 1;
                    nums[i] = matrix[row, column];
                    flags[row, column] = 1;
                    continue;
                }

                if (dir == 2)
                {
                    if (column == 0 || flags[row , column -1] == 1)
                    {
                        row -= 1;
                        nums[i] = matrix[row, column];
                        flags[row, column] = 1;
                        dir = 3;
                        continue;
                    }

                    column -= 1;
                    nums[i] = matrix[row, column];
                    flags[row, column] = 1;
                    continue;
                }

                if(dir == 3)
                {
                    if(row == 0 || flags[row -1 ,column] == 1)
                    {
                        column += 1;
                        nums[i] = matrix[row, column];
                        flags[row, column] = 1;
                        dir = 0;
                        continue;
                    }

                    row -= 1;
                    nums[i] = matrix[row, column];
                    flags[row, column] = 1;
                    continue;
                }
            }

            return nums;
        }
    }
}
