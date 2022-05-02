public class Solution {
    public int MaxProfit(int[] prices) {
        
            int size = prices.Length;
            if(size==0 || size ==1) 
                return 0;
            int[] profit = new int[size];
            int[] profit1 = new int[size];
            int local_min=prices[0];
            int local_max = prices[size-1];
            int j = size-2;
            int result=0;
            profit[0]=0;
            profit1[size-1] = 0;
            for(int i = 1; i < size + 1 && j >= 0; i++, j--)
            {
                profit[i] = Math.Max(profit[i-1], prices[i] - local_min);
                local_min = Math.Min(local_min, prices[i]);
                profit1[j] = Math.Max(profit1[j+1],local_max - prices[j]);
                local_max = Math.Max(local_max,prices[j]);
            }
            for(int i = 1; i < size; i++)
            {
                result = Math.Max(result,profit[i]+profit1[i]);
            }
            return result;
    }
}