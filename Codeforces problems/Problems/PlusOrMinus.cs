using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class PlusOrMinus
    {
        public static void Solve()
        {
            int testCases = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < testCases; i++)
            {
                int[] nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                if (nums[0] + nums[1] == nums[2])
                {
                    Console.WriteLine("+");
                }
                else if (nums[0] - nums[1] == nums[2])
                {
                    Console.WriteLine("-");
                }
            }
        }
    }
}
