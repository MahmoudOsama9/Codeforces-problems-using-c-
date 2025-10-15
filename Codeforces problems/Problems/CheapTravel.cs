using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class CheapTravel
    {
        public static void Solve()
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRides = inputs[0];
            int mRideTicket = inputs[1];
            int priceOfAnMRideTicket = inputs[3];
            int oneRideTicket = inputs[2];

            int totalPrice = 0;

            int fullMRideTickets = numberOfRides / mRideTicket;
            int remainingRides = numberOfRides % mRideTicket;

            int costOption1 = fullMRideTickets * priceOfAnMRideTicket;
            costOption1 += remainingRides * oneRideTicket;

            int costOption2 = (fullMRideTickets + 1) * priceOfAnMRideTicket;

            int costOption3 = numberOfRides * oneRideTicket;

            totalPrice = Math.Min(costOption1, Math.Min(costOption2, costOption3));

            Console.WriteLine(totalPrice);
        }
    }
}
