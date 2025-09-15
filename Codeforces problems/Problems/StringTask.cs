using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class StringTask
    {
        public static void Solve()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine(input);
                return;
            }
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if ("aeiouy".Contains(char.ToLower(c)))
                {
                    continue;
                }
                if (char.IsUpper(c))
                {
                    result.Append('.').Append(char.ToLower(c));
                }
                else
                {
                    result.Append('.').Append(c);
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
