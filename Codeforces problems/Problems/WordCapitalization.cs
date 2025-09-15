using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class WordCapitalization
    {
        public static void Solve()
        {
            string word = Console.ReadLine();
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine(word);
                return;
            }
            char firstChar = char.ToUpper(word[0]);
            string capitalizedWord = firstChar + word.Substring(1);
            Console.WriteLine(capitalizedWord);
        }
    }
}
