using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class GameWithSticks
    {
        public static void Solve()
        {
            int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int totalMoves = Math.Min(inputs[1], inputs[0]);

            if (totalMoves % 2 == 0)
            {
                Console.WriteLine("Malvika");
            }
            else
            {
                Console.WriteLine("Akshat");
            }
        }
    }
}
