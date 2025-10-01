using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class IWannaBeTheGuy
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine()!);
            HashSet<int> levels = new HashSet<int>();
            int p = int.Parse(Console.ReadLine()!);
            if (p > 0)
            {
                int[] player1Levels = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                foreach (int level in player1Levels)
                {
                    levels.Add(level);
                }
            }
            else
            {
                Console.ReadLine();
            }
            int q = int.Parse(Console.ReadLine()!);
            if (q > 0)
            {
                int[] player2Levels = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                foreach (int level in player2Levels)
                {
                    levels.Add(level);
                }
            }
            else
            {
                Console.ReadLine();
            }
            if (levels.Count == n)
            {
                Console.WriteLine("I become the guy.");
            }
            else
            {
                Console.WriteLine("Oh, my keyboard!");
            }
        }
    }
}
