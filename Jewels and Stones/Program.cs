using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels_and_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            string J = "z";
            string S = "ZZ";

            Console.WriteLine(NumJewelsInStones(J, S));
            Console.ReadKey();
            

        }

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
