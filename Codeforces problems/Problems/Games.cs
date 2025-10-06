using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Games
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            string[] moves = Console.ReadLine().Split();
            int countA = 0;
            int countD = 0;
            foreach (string move in moves)
            {
                if (move == "A")
                {
                    countA++;
                }
                else if (move == "D")
                {
                    countD++;
                }
            }
            if (countA > countD)
            {
                Console.WriteLine("Anton");
            }
            else if (countD > countA)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }
        }
    }
}
