using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class Jewels_and_Stones
    {
        public static int NumJewelsInStones(string J, string S)
        {
            int num = 0;
            foreach (var charc in J)
            {
                num += S.Where(str => str.Equals(charc)).Count();
            }

            return num;
        }
    }
}
