using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class YoungPhysicist
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());

            int sumX = 0;
            int sumY = 0;
            int sumZ = 0;

            for (int i = 0; i < n; i++)
            {
                int[] coordinates = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                sumX += coordinates[0];
                sumY += coordinates[1];
                sumZ += coordinates[2];
            }

            if (sumX == 0 && sumY == 0 && sumZ == 0)
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
