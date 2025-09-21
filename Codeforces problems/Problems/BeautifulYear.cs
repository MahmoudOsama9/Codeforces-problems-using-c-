using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class BeautifulYear
    {
        public static void Solve()
        {
            bool checkBeautifulYear(int year)
            {

                HashSet<int> numberSet = new HashSet<int>();

                while (year != 0)
                {
                    if (!numberSet.Contains(year % 10))
                    {
                        numberSet.Add(year % 10);
                    }

                    else
                    {
                        return false;
                    }
                    year /= 10;
                }

                return true;
            }

            int year = int.Parse(Console.ReadLine());

            int nextBeautifulYear = year + 1;
            bool flag = false;

            while (true)
            {
                flag = checkBeautifulYear(nextBeautifulYear);
                if (flag)
                {
                    break;
                }
                nextBeautifulYear++;
            }

            Console.WriteLine(nextBeautifulYear);






        }
    }
}
