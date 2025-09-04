using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Elephant
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            int steps = (n + 4) / 5;
            Console.WriteLine(steps);
        }
    }
}
