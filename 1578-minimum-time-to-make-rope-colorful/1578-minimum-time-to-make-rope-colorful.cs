public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        if(colors == null || colors.Length == 0 || neededTime == null || neededTime.Length == 0)
            return 0;
        
        int res = 0, maxCost = neededTime[0];
        for(int i = 1; i < colors.Length; i++)
        {
            if(colors[i] == colors[i-1])
            {
                res += Math.Min(maxCost, neededTime[i]);
                maxCost = Math.Max(maxCost, neededTime[i]);
            }
            else
            {
                maxCost = neededTime[i];   
            }
        }
        
        return res;
    }
}