using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class GravityFlip
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            int[] columns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(columns);
            Console.WriteLine(string.Join(" ", columns));
        }
    }
}
