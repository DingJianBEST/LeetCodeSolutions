using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2,5,5,11 };
            int target = 10;

            var result = TwoSum(nums, target);

            Console.WriteLine("{0} and {1}", result[0], result[1]);

            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length ; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };

                    
                }
            }

            return new int[] { 0, 0 };
        }
    }


}
