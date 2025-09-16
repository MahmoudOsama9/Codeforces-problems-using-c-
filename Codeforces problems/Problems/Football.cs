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
            int input = int.Parse(Console.ReadLine());
            int onescounters = 0;
            int zerocounters = 0;
            while (input > 0) { 
                if (input % 10 == 1) { onescounters++; if (onescounters == 7) break; }
                else if (input % 10 == 0) { zerocounters++; if (zerocounters == 7) break; }
                else { onescounters = 0; zerocounters = 0; }
                input /= 10;
            }
            if (zerocounters == 7) { Console.WriteLine("YES"); }
            else { Console.WriteLine("NO"); }
            //for (int i = 0; i < k; i++)
            //{
            //    if (n % 10 == 0)
            //    {
            //        n /= 10;
            //    }
            //    else
            //    {
            //        n -= 1;
            //    }
            //}
            //Console.WriteLine(n);
        }
    }
}
