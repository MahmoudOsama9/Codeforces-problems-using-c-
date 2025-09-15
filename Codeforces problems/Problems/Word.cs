using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Word
    {
        public static void Solve()
        {
            string word = Console.ReadLine();
            int upperCount = word.Count(char.IsUpper);
            int lowerCount = word.Count(char.IsLower);
            if (upperCount > lowerCount)
            {
                Console.WriteLine(word.ToUpper());
            }
            else
            {
                Console.WriteLine(word.ToLower());
            }
        }
    }
}
