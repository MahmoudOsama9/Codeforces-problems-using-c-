using System;
using System.Linq;

namespace Codeforces_problems.Problems
{
    public class I_love__username_
    {
        public static void Solve()
        {
            int contests = int.Parse(Console.ReadLine()!);
            int[] scores = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            if (scores.Length == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int minScore = scores[0];
            int maxScore = scores[0];
            int counter = 0;

            for (int i = 1; i < contests; i++)
            {
                if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    counter++;
                }
                else if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
