  public int MaxProfit(int[] prices) {
        if(prices.Length ==0|| prices.Length==1) return 0;
        int max_pro=0;
        for(int i=prices.Length-1;i>0;i--){
          if(prices[i]-prices[i-1]>0) max_pro+=prices[i]-prices[i-1];
        }
        return max_pro;
    }
