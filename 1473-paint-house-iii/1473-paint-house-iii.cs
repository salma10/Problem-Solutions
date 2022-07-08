public class Solution {
    public int MinCost(int[] houses, int[][] cost, int m, int n, int target) {
        int[][][] dp = new int[m][][];
        for(int i = 0; i < m; i++)
        {
            dp[i] = new int[n][];
            for(int j = 0; j < n; j++)
            {
                dp[i][j] = Enumerable.Repeat(int.MaxValue, m + 1).ToArray();
            }
        }
        if (houses[0] == 0)
        {
            for(int j = 0; j < n; j++)
            {
                dp[0][j][1] = cost[0][j];
            }
        }
        else
            dp[0][houses[0] - 1][1] = 0;
        
        for(int i = 1; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                for(int k = 1; k <= m; k++)
                {
                    if (dp[i-1][j][k] != int.MaxValue)
                    {
                        if (houses[i] == 0)
                        {
                            for(int l = 0; l < n; l++)
                            {
                                int newk = k + (l == j ? 0 : 1);
                                dp[i][l][newk] = Math.Min(dp[i][l][newk], dp[i - 1][j][k] + cost[i][l]);
                            }
                        }
                        else
                        {
                            int l = houses[i]-1;
                            int newk = k + (l == j ? 0 : 1);
                            dp[i][l][newk] = Math.Min(dp[i][l][newk], dp[i - 1][j][k]);
                        }
                    }
                }
            }
        }
        
        int res = int.MaxValue;
        
        for(int i = 0; i < n; i++)
        {
            res = Math.Min(res, dp[m - 1][i][target]);
        }
        return res == int.MaxValue ? -1 : res;
    }
}