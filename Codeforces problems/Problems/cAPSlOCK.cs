using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class cAPSlOCK
    {
        public static void Solve()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine(input);
                return;
            }

            bool conditionAllUpper = input.All(char.IsUpper);

            bool conditionFirstLowerRestUpper = false;
            if (input.Length > 0)
            {
                conditionFirstLowerRestUpper = char.IsLower(input[0]) && input.Skip(1).All(char.IsUpper);
            }

            if (conditionAllUpper)
            {
                Console.WriteLine(input.ToLower());
            }
            else if (conditionFirstLowerRestUpper)
            {
                StringBuilder result = new StringBuilder();
                result.Append(char.ToUpper(input[0]));
                for (int i = 1; i < input.Length; i++)
                {
                    result.Append(char.ToLower(input[i]));
                }
                Console.WriteLine(result.ToString());
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
