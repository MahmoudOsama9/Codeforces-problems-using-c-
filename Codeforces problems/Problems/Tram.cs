using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Tram
    {
        public static void Solve()
        {
            int stops = int.Parse(Console.ReadLine());

            int maxCapacity = 0;
            int currentCapacity = 0;

            for (int i = 0; i < stops; i++)
            {
                int[] inputsForStop = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int exits = inputsForStop[0];
                int enter = inputsForStop[1];

                currentCapacity += enter - exits;
                if (currentCapacity > maxCapacity)
                {
                    maxCapacity = currentCapacity;
                }
            }

            Console.WriteLine(maxCapacity);
        }
    }
}
