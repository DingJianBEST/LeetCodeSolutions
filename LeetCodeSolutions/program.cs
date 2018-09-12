using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class program
    {
        public static void Main()
        {
            char[,] chas = { { '1','1','0','0','0'},
                             { '1','1','0','0','0'},
                             { '0','0','1','0','0'},
                             {'0','0','0','1','1' }
                           };

            _200_NumberOfIslands.NumIslands(chas);
        }
    }
}
