using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Bit__
    {
        public static void Solve()
        {
            int Result = 0;
            int NumberOfStatements = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfStatements; i++)
            {
                string statement = Console.ReadLine();
                if (statement.Contains("++")){
                    Result++;
                }
                else {
                    Result--;
                }
            }
            Console.WriteLine(Result);
        }
    }
}
