using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class XeniaAndRingroad
    {
        public static void Solve()
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            int[] tasks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long totalTime = 0;
            int currentHouse = 1;

            foreach (int targetHouse in tasks)
            {
                if (targetHouse >= currentHouse)
                {
                    totalTime += (targetHouse - currentHouse);
                }
                else
                {
                    totalTime += (n - currentHouse + targetHouse);
                }

                currentHouse = targetHouse;
            }

            Console.WriteLine(totalTime);
        }
    }
}
