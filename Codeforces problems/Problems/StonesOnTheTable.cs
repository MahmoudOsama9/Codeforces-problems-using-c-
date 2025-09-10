using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class StonesOnTheTable
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (s[i] == s[i - 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
