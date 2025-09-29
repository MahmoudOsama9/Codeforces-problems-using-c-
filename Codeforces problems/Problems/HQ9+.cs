using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class HQ9_
    {
        public static void Solve()
        {
            string s = Console.ReadLine();
            if (s.Contains('H') || s.Contains('Q') || s.Contains('9'))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
