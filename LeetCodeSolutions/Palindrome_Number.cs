using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class Palindrome_Number
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            else
            {
                string reverseNum = "";

                string num = x.ToString();

                foreach (var charc in num.Reverse())
                    reverseNum += charc;

                if (reverseNum.Equals(num))
                    return true;

                return false;
            }
        }
    }
}
