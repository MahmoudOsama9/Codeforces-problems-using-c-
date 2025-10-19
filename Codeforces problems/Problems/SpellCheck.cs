using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class SpellCheck
    {
        public static void Solve()
        {
            int testCases = int.Parse(Console.ReadLine()!);
            char[] targetChars = "Timur".ToCharArray();
            Array.Sort(targetChars);

            for (int i = 0; i < testCases; i++)
            {
                int length = int.Parse(Console.ReadLine()!);
                string name = Console.ReadLine()!;

                if (length != 5)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                char[] nameChars = name.ToCharArray();
                Array.Sort(nameChars);

                if (nameChars.SequenceEqual(targetChars))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
