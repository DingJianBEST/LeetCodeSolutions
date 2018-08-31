using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            Console.WriteLine(IsPalindrome2(x));
            Console.ReadKey();
        }

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

        public static bool IsPalindrome2(int x)
        {
            if (x < 0)
                return false;
            else
            {
                int num = 0;
                int tmp = x;
                while(tmp != 0 )
                {
                    num = num * 10 + tmp % 10;
                    tmp = tmp / 10;
                }

                return num == x;
            }
        }
    }
}
