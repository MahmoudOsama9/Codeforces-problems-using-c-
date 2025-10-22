using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class SpyDetected
    {
        public static void Solve()
        {
            int testCases = int.Parse(Console.ReadLine()!);
            for (int t = 0; t < testCases; t++)
            {
                int length = int.Parse(Console.ReadLine()!);
                string[] ids = Console.ReadLine()!.Split(' ');

                Dictionary<string, int> idCounts = new Dictionary<string, int>();
                foreach (string id in ids)
                {
                    if (idCounts.ContainsKey(id))
                    {
                        idCounts[id]++;
                    }
                    else
                    {
                        idCounts[id] = 1;
                    }
                }

                string uniqueId = "";

                foreach (var kvp in idCounts)
                {
                    if (kvp.Value == 1)
                    {
                        uniqueId = kvp.Key;
                        break;
                    }
                }
                for (int i = 0; i < ids.Length; i++)
                {
                    if (ids[i] == uniqueId)
                    {
                        Console.WriteLine(i + 1);
                        break;
                    }
                }
            }
        }
    }
}
