using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class InSearchOfAnEasyProblem
    {
        public static void Solve()
        {
            int size = int.Parse(Console.ReadLine());

            int[] votes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isHard = false;

            if (votes.Sum() > 0)
            {
                isHard = true;
            }

            Console.WriteLine(isHard ? "HARD" : "EASY");
        }
    }
}
