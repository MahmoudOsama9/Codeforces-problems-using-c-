using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class Games
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());

            int[] homeColors = new int[n];
            int[] awayColors = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] colors = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                homeColors[i] = colors[0];
                awayColors[i] = colors[1];
            }

            int gamesWithHostInGuestUniform = 0;

            for (int hostTeamIndex = 0; hostTeamIndex < n; hostTeamIndex++)
            {
                for (int guestTeamIndex = 0; guestTeamIndex < n; guestTeamIndex++)
                {
                    if (hostTeamIndex == guestTeamIndex)
                    {
                        continue;
                    }

                    int hostHomeColor = homeColors[hostTeamIndex];

                    int guestAwayColor = awayColors[guestTeamIndex];

                    if (hostHomeColor == guestAwayColor)
                    {
                        gamesWithHostInGuestUniform++;
                    }
                }
            }
            Console.WriteLine(gamesWithHostInGuestUniform);
        }
    }
}
