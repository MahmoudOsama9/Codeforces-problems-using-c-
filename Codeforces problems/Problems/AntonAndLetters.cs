using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class AntonAndLetters
    {
        public static void Solve()
        {
            string input = Console.ReadLine()!;

            HashSet<char> distinctLetters = new HashSet<char>();

            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    distinctLetters.Add(c);
                }
            }

            Console.WriteLine(distinctLetters.Count);
        }
    }
}
