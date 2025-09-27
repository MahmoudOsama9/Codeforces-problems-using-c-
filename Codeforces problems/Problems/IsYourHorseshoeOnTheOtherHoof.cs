using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class IsYourHorseshoeOnTheOtherHoof
    {
        public static void Solve()
        {
            int[] colors = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            HashSet<int> uniqueColors = new HashSet<int>();

            foreach (int color in colors)
            {
                uniqueColors.Add(color);
            }

            int horseshosesToBuy = 4 - uniqueColors.Count;

            Console.WriteLine(horseshosesToBuy);
        }
    }
}
