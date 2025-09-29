using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class HitTheLottery
    {
        public static void Solve()
        {
            int amount = int.Parse(Console.ReadLine());
            int[] denominations = new int[] { 100, 20, 10, 5, 1 };
            int count = 0;
            foreach (int denomination in denominations)
            {
                count += amount / denomination;
                amount %= denomination;
            }
            Console.WriteLine(count);
        }
    }
}
