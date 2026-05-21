using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public class GainMostProfit
    {
        public static void RunGainMostProfit(int[] prices)
        {
            int maxProfit = 0;
            for(int i = 1; i< prices.Length - 1; i++)
            {
                if (prices[i + 1] > prices[i])
                {
                    maxProfit += prices[i + 1] - prices[i];
                }
            }
            Console.WriteLine($"max profit is : {maxProfit}");
        }
    }
}
