using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class NearlyLuckyNumber
    {
        public static void Solve()
        {
            string n = Console.ReadLine();
            int luckyDigitCount = n.Count(c => c == '4' || c == '7');
            if (luckyDigitCount == 4 || luckyDigitCount == 7)
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
