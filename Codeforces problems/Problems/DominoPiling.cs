using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class DominoPiling
    {
        public static void Solve()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int maxDominoes = (n * m) / 2;
            Console.WriteLine(maxDominoes);
        }
    }
}
