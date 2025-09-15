using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class BoyOrGirl
    {
        public static void Solve()
        {
            string username = Console.ReadLine();
            int uniqueCharCount = username.Distinct().Count();
            if (uniqueCharCount % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
        }
    }
}
