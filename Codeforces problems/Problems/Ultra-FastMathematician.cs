using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Ultra_FastMathematician
    {
        public static void Solve()
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] == num2[i])
                {
                    result.Append('0');
                }
                else
                {
                    result.Append('1');
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
