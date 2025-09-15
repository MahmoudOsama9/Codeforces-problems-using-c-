using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class TheatreSquare
    {
        public static void Solve()
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);
            long a = long.Parse(input[2]);
            long tilesAlongLength = (n + a - 1) / a;
            long tilesAlongWidth = (m + a - 1) / a;
            long totalTiles = tilesAlongLength * tilesAlongWidth;
            Console.WriteLine(totalTiles);
        }
    }
}
