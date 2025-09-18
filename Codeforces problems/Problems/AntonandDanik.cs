using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class AntonandDanik
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int antonWins = s.Count(c => c == 'A');
            int danikWins = s.Count(c => c == 'D');
            if (antonWins > danikWins)
            {
                Console.WriteLine("Anton");
            }
            else if (danikWins > antonWins)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }
        }
    }
}
