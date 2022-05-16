using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.LeetCode
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

    public class BestTime_Buy_Sell_Stock
    {
        //        Input: prices = [7,1,5,3,6,4]
        //        Output: 5
        //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        //Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

        // You are given an array prices where prices[i] is the price of a given stock on the ith day.
        //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
        //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.

        //https://www.youtube.com/watch?v=3RHCb8LY-X4
        public int MaxProfit_m1(int[] prices)
        {
            int min_val = int.MaxValue;
            int Max_val = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min_val)
                {
                    min_val = prices[i];
                }
                //Math.Max(Max_val, prices[i] - min_val);
                else if (prices[i] - min_val > Max_val)
                {

                    Max_val = prices[i] - min_val;
                }

            }

            return Max_val;

        }

        //https://www.youtube.com/watch?v=mj7N8pLCJ6w
        public int MaxProfit_m2(int[] prices)
        {
            int min_val = int.MaxValue;
            int Max_val = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min_val)
                {
                    min_val = prices[i];
                }
                else
                {
                    Max_val = Math.Max(Max_val, prices[i] - min_val);
                }

            }


            return Max_val;

        }

    }
}
