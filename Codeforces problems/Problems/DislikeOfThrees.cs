using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class DislikeOfThrees
    {
        public static void Solve() {
            int[] likedNumbers = new int[1001];
            int likedCount = 0;
            int currentNumber = 1;
            while (likedCount < 1000)
            {
                if (currentNumber % 3 != 0 && currentNumber % 10 != 3)
                {
                    likedNumbers[likedCount] = currentNumber;
                    likedCount++;
                }
                currentNumber++;
            }

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int k = int.Parse(Console.ReadLine());

                Console.WriteLine(likedNumbers[k - 1]);
            }
        }
    }
}
