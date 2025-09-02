using System;

namespace Codeforces_problems.Problems
{
    public class Team
    {
        public static void Solve()
        {
            int problems = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < problems; i++)
            {
                int[] opinions = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (opinions.Sum() >= 2)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
