using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class _200_NumberOfIslands
    {
        static int m = 0;
        static int n = 0;
        public static int NumIslands(char[,] grid)
        {
            m = grid.GetLength(0);
            n = grid.GetLength(1);
            int res = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i, j] == '1')
                    {
                        res++;
                        DFS(i, j, grid);
                    }
                }
            }

            return res;
        }

        public static void DFS(int i, int j, char[,] grid)
        {
            grid[i, j] = '0';

            if (i > 0 && grid[i - 1, j] == '1')
                DFS(i - 1, j, grid);
            if (j > 0 && grid[i, j - 1] == '1')
                DFS(i, j - 1, grid);
            if (i < m - 1 && grid[i + 1, j] == '1')
                DFS(i + 1, j, grid);
            if (j < n - 1 && grid[i, j + 1] == '1')
                DFS(i, j + 1, grid);
        }
    }
}
