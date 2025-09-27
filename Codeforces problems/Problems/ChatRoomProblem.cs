using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class ChatRoomProblem
    {
        public static void Solve()
        {
            string s = Console.ReadLine();

            string target = "hello";

            int sPointer = 0;
            int targetPointer = 0;

            while (sPointer < s.Length && targetPointer < target.Length)
            {
                if (s[sPointer] == target[targetPointer])
                {
                    targetPointer++;
                }
                sPointer++;
            }

            if (target.Length == targetPointer)
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
