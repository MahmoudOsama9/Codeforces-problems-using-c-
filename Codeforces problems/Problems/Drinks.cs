using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Drinks
    {
        public static void Solve()
        {
            int num = int.Parse(Console.ReadLine());
            string[] percentages = Console.ReadLine().Split(' ');
            double totalPercentage = 0;
            foreach (string percentage in percentages)
            {
                totalPercentage += double.Parse(percentage);
            }
            double averagePercentage = totalPercentage / num;
            Console.WriteLine(averagePercentage);
        }
    }
}
