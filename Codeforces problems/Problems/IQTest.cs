using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class IQTest
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();
            List<int> evenIndices = new List<int>();
            List<int> oddIndices = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(numbers[i]);
                if (num % 2 == 0)
                {
                    evenIndices.Add(i + 1);
                }
                else
                {
                    oddIndices.Add(i + 1);
                }
            }
            if (evenIndices.Count == 1)
            {
                Console.WriteLine(evenIndices[0]);
            }
            else
            {
                Console.WriteLine(oddIndices[0]);
            }
        }
    }
}
