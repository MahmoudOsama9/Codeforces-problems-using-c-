using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class CandiesAndTwoSisters
    {
        public static void Solve()
        {
            int iterations = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < iterations; i++)
            {
                int candies = int.Parse(Console.ReadLine()!);
                if (candies <= 2)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine((candies - 1) / 2);
                }
            }
        }
    }
}