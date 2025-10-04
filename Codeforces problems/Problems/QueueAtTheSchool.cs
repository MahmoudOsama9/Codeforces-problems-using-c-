using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class QueueAtTheSchool
    {
        public static void Solve()
        {
            string[] inputs = Console.ReadLine()!.Split(' ');
            int n = int.Parse(inputs[0]);
            int t = int.Parse(inputs[1]);
            char[] queue = Console.ReadLine()!.ToCharArray();
            for (int time = 0; time < t; time++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (queue[i] == 'B' && queue[i + 1] == 'G')
                    {
                        queue[i] = 'G';
                        queue[i + 1] = 'B';
                        i++;
                    }
                }
            }
            Console.WriteLine(new string(queue));
        }
    }
}
