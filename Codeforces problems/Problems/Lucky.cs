using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Lucky
    {
        public static void Solve()
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                string num = Console.ReadLine();

                int firstThreeDigitsSum = 0;
                int secondThreeDigitsSum = 0;

                for (int j = 0; j < 3; j++)
                {
                    firstThreeDigitsSum += (num[j] - '0');
                }

                for (int j = 3; j < num.Length; j++)
                {
                    secondThreeDigitsSum += (num[j] - '0');
                }

                if (firstThreeDigitsSum == secondThreeDigitsSum)
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
