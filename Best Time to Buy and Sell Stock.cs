/*
Say you have an array for which the ith element is the price of a given stock on day i.

If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.

Note that you cannot sell a stock before you buy one.
*/

 public int MaxProfit(int[] prices) {
        
         int max=0;
        int current=0;
        
        for(int i=1; i < prices.Length; i++){
            
            current+=prices[i]-prices[i-1];
            
            if(current<0)
              current=0;
            else if(current>max) 
              max=current;
              
        }
        return max;
        
    }
