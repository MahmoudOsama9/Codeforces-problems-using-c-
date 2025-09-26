using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class EvenOdds
    {
        public static void Solve()
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long n = long.Parse(inputs[0]);
            long k = long.Parse(inputs[1]);
            long oddCount = (n + 1) / 2;
            if (k <= oddCount)
            {
                Console.WriteLine(2 * k - 1);
            }
            else
            {
                Console.WriteLine(2 * (k - oddCount));
            }
        }
    }
}
