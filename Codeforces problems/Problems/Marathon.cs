using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Marathon
    {
        public static void Solve()
        {
            int testCases = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < testCases; i++)
            {
                int[] nums = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

                int counter = 0;

                for (int j = 1; j < 4; j++)
                {
                    if (nums[0] < nums[j])
                    {
                        counter++;
                    }
                }

                Console.WriteLine(counter);
            }
        }
    }
}
