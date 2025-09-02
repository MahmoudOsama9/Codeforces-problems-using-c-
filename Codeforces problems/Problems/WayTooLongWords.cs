using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class WayTooLongWords
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string w = Console.ReadLine();
                Console.WriteLine(w.Length > 10 ? $"{w[0]}{w.Length - 2}{w[^1]}" : w);
            }
        }
}
}
