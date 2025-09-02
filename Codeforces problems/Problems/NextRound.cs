using System;
using System.Linq;

namespace Codeforces_problems.Problems
{
    public class NextRound
    {
        public static void Solve()
        {
            int[] sizeAndThresholder = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int size = sizeAndThresholder[0], k = sizeAndThresholder[1];

            int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int cutoff = scores[k - 1];
            int counter = 0;

            foreach (int s in scores)
            {
                if (s >= cutoff && s > 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
