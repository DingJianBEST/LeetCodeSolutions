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
            _739_dailytemperature t = new _739_dailytemperature();
            int[] n = new int[] { 89, 62, 70, 58, 47, 47, 46, 76, 100, 70 };
            var num = t.DailyTemperatures(n);
        }
    }
}
