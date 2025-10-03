using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class InsomniaCure
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine()!);
            int k1 = int.Parse(Console.ReadLine()!);
            int k2 = int.Parse(Console.ReadLine()!);
            int k3 = int.Parse(Console.ReadLine()!);
            HashSet<int> disturbed = new HashSet<int>();
            for (int i = k1; i <= n; i += k1)
            {
                disturbed.Add(i);
            }
            for (int i = k2; i <= n; i += k2)
            {
                disturbed.Add(i);
            }
            for (int i = k3; i <= n; i += k3)
            {
                disturbed.Add(i);
            }
            Console.WriteLine(n - disturbed.Count);
        }
    }
}
