using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Sum
    {
        public static void Solve()
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if ((nums[0] == nums[1] + nums[2]) ||
                (nums[1] == nums[0] + nums[2]) ||
                (nums[2] == nums[0] + nums[1]))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
