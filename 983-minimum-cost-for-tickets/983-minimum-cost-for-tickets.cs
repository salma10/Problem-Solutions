public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        int last = days[days.Length - 1];
        int[] dp = new int[last + 1];
        HashSet<int> travelledDays = new HashSet<int>(days);
        
        dp[0] = 0;
        for(int i = 1; i < dp.Length; i++)
        {
            if(!travelledDays.Contains(i))
            {
                dp[i] = dp[i - 1];
                continue;
            }
            int dailyCost = costs[0] + dp[i - 1];
            int weeklyCost = costs[1] + dp[Math.Max(0, i - 7)];
            int monthlyCost = costs[2] + dp[Math.Max(0, i - 30)];
            dp[i] = Math.Min(dailyCost, Math.Min(weeklyCost, monthlyCost));
        }
        return dp[last];
    }
}