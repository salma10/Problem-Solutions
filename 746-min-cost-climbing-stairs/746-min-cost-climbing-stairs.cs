public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int first = 0, second = 0;
        for(int i = 2; i <= cost.Length; i++)
        {
            int temp = second;
            second = Math.Min(second + cost[i - 1], first + cost[i - 2]);
            first = temp;
        }        
        return second;
    }
}