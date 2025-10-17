using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class SumOfRoundNumbers
    {
        public static void Solve()
        {
            int t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine()!);

                List<int> roundNumbers = new List<int>();

                int powerOfTen = 1;

                while (n > 0)
                {
                    int digit = n % 10;

                    if (digit != 0)
                    {
                        roundNumbers.Add(digit * powerOfTen);
                    }
                    n /= 10;
                    powerOfTen *= 10;
                }

                Console.WriteLine(roundNumbers.Count);

                Console.WriteLine(string.Join(" ", roundNumbers));
        }
        }
    }
}
