public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {
         int[,] dp = new int[m+1,n+1];
        int zeros,ones;
        for(int i=0;i<strs.Length;i++)
        {
            zeros = 0;
            for(int j=0;j<strs[i].Length;j++)
                if(strs[i][j]=='0')
                    zeros++;
            ones = strs[i].Length-zeros;
            
            for(int j=m;j>=zeros;j--)
                for(int k=n;k>=ones;k--)
                    dp[j,k]=Math.Max(dp[j,k],1+dp[j-zeros,k-ones]);
        }
        return dp[m,n];
    }
}