public class Solution {
    public int MaxProfit(int[] prices) {        
        int max = 0;
        int current = 0;
        
        for(int i = 1; i < prices.Length; i++)
        {
            current += prices[i] - prices[i-1];
            if(current < 0)
              current = 0;
            else if(current > max) 
              max = current;
        }
        return max;
    }
}