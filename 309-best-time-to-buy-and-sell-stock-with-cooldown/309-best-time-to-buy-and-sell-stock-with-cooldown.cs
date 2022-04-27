public class Solution {
    public int MaxProfit(int[] prices) {
        int sold = int.MinValue, held = int.MinValue, reset = 0;
        for (int i = 0; i < prices.Length; i++) 
        {
          int preSold = sold;
          sold = held + prices[i];
          held = Math.Max(held, reset - prices[i]);
          reset = Math.Max(reset, preSold);
        }
        return Math.Max(sold, reset);
    }
}