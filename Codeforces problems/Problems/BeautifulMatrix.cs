using System;

namespace Codeforces_problems.Problems
{
    public class BeautifulMatrix
    {
        public static void Solve()
        {
            int oneRow = 0, oneCol = 0;

            for (int i = 1; i <= 5; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int j = 1; j <= 5; j++)
                {
                    if (line[j - 1] == "1")
                    {
                        oneRow = i;
                        oneCol = j;
                    }
                }
            }

            int moves = Math.Abs(oneRow - 3) + Math.Abs(oneCol - 3);

            Console.WriteLine(moves);
        }
    }
}
