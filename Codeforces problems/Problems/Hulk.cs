using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Hulk
    {
        public static void Solve()
        {
            int num = int.Parse(Console.ReadLine());

            StringBuilder feelings = new StringBuilder();

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    feelings.Append("I hate");
                }
                else
                {
                    feelings.Append("I love");
                }

                if (i < num)
                {
                    feelings.Append(" that ");
                }

            }

            feelings.Append(" it");

            Console.WriteLine(feelings);
        }
    }
}
