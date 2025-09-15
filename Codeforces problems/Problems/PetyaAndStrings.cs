using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class PetyaAndStrings
    {
        public static void Solve()
        {
            string str1 = Console.ReadLine().ToLower();
            string str2 = Console.ReadLine().ToLower();
            int comparisonResult = string.Compare(str1, str2);
            if (comparisonResult < 0)
            {
                Console.WriteLine("-1");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
