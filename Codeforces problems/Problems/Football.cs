using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Football
    {
        public static void Solve()
        {
            string s = Console.ReadLine();

            int consecutiveOnes = 0;
            int consecutiveZeros = 0;
            bool dangerous = false;

            foreach (char c in s)
            {
                if (c == '1')
                {
                    consecutiveOnes++;
                    consecutiveZeros = 0;
                }
                else if (c == '0')
                {
                    consecutiveZeros++;
                    consecutiveOnes = 0;
                }

                if (consecutiveOnes >= 7 || consecutiveZeros >= 7)
                {
                    dangerous = true;
                    break;
                }
            }

            if (dangerous)
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
