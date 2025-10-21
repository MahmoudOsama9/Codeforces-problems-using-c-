using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Division
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 1900)
                {
                    Console.WriteLine("Division 1");
                }
                else if (x >= 1600)
                {
                    Console.WriteLine("Division 2");
                }
                else if (x >= 1400)
                {
                    Console.WriteLine("Division 3");
                }
                else
                {
                    Console.WriteLine("Division 4");
                }
            }
        }
    }
}
