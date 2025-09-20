using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class VanyaAndFence
    {
        public static void Solve()
        {
            int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfFriends = inputs[0];
            int height = inputs[1];

            int[] friends = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bend = 0;

            foreach (int friend in friends)
            {
                if (friend > height)
                {
                    bend += 2;
                }
                else
                {
                    bend += 1;
                }
            }

            Console.WriteLine(bend);

        }
    }
}
