using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Expression
    {
        public static void Solve()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int expr1 = a + b + c;
            int expr2 = a * b * c;
            int expr3 = (a + b) * c;
            int expr4 = a * (b + c);
            int expr5 = a + (b * c);
            int expr6 = (a * b) + c;

            int max_val = Math.Max(expr1, expr2);
            max_val = Math.Max(max_val, expr3);
            max_val = Math.Max(max_val, expr4);
            max_val = Math.Max(max_val, expr5);
            max_val = Math.Max(max_val, expr6);

            Console.WriteLine(max_val);
        }
    }
}
