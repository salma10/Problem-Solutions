public class Solution {   
    public int MinDifficulty(int[] jobDifficulty, int d) {
        int n = jobDifficulty.Length;
        if(n < d)
            return -1;
        int[][] memo = new int[n][];
        for(int i = 0; i < n; i++)
            memo[i] = Enumerable.Repeat<int>(Int32.MaxValue, d + 1).ToArray();
        
        memo[n - 1][d] = jobDifficulty[n - 1];
        
        for(int i = n - 2; i >= 0; i--)
        {
            memo[i][d] = Math.Max(memo[i + 1][d], jobDifficulty[i]);
        }
        for(int day = d - 1; day > 0; day--)
        {
            for(int i = day - 1; i < n - (d - day); i++)
            {
                int hardest = 0;
                for(int j = i; j < n - (d - day); j++)
                {
                    hardest = Math.Max(hardest, jobDifficulty[j]);
                    memo[i][day] = Math.Min(memo[i][day], hardest + memo[j + 1][day + 1]);
                }
            }
        }
        
        return memo[0][1];
    }
}