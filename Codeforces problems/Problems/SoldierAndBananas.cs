using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class SoldierAndBananas
    {
        public static void Solve()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int totalCost = k * w * (w + 1) / 2;
            int amountToBorrow = totalCost - n;
            Console.WriteLine(amountToBorrow > 0 ? amountToBorrow : 0);
        }
    }
}
