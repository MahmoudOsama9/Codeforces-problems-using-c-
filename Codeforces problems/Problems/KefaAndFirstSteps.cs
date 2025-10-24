using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class KefaAndFirstSteps
    {
        public static void Solve()
        {
            int length = int.Parse(Console.ReadLine()!);
            int[] nums = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < length; i++)
            {
                if (nums[i] >= nums[i - 1])
                {
                    currentLength++;

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            Console.WriteLine(maxLength);
        }
    }
}
