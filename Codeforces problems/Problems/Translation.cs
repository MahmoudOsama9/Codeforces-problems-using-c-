using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Translation
    {
        public static void Solve()
        {

            string BerlandWord = Console.ReadLine();
            string BirlandWord = Console.ReadLine();

            bool flag = true;

            if (BerlandWord.Length != BirlandWord.Length)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < BerlandWord.Length; i++)
            {
                char charBerland = BerlandWord[i];
                char charBirland = BirlandWord[BirlandWord.Length - 1 - i];

                if (charBerland != charBirland && !(charBerland == 's' && charBirland == 't'))
                {
                    flag = false;
                    break;
                }
            }

            Console.WriteLine(flag ? "YES" : "NO");
        }
    }
}
