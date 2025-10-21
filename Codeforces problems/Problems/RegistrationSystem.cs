using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class RegistrationSystem
    {
        public static void Solve()
        {
            int testCases = int.Parse(Console.ReadLine()!);

            Dictionary<string, int> userNames = new Dictionary<string, int>();

            for(int i = 0; i < testCases; i++)
            {
                string userName = Console.ReadLine()!;

                if (!userNames.ContainsKey(userName))
                {
                    userNames.Add(userName, 0);
                    Console.WriteLine("OK");
                    continue;
                }

                userNames[userName] += 1;

                Console.WriteLine(userName + userNames[userName]);
            }
        }
    }
}
