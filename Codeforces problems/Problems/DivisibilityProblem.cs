using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class DivisibilityProblem
    {
        public static void Solve()
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int a = inputs[0];
                int b = inputs[1];
                int counter = 0;

                if (a % b != 0)
                {
                    counter = b - (a % b);
                }

                Console.WriteLine(counter);
            }
        }
    }
}
