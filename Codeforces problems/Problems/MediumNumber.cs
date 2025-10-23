using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class MediumNumber
    {
        public static void Solve()
        {
            int testCases = int.Parse(Console.ReadLine()!);
            for (int t = 0; t < testCases; t++)
            {
                string[] numbers = Console.ReadLine()!.Split(' ');
                int[] nums = Array.ConvertAll(numbers, int.Parse);
                Array.Sort(nums);
                Console.WriteLine(nums[1]);
            }
        }
    }
}
