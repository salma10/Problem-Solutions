public class Solution {
    bool isSquare = false;
    
    public bool Makesquare(int[] matchsticks) {
        int n = matchsticks.Length;
        if (n < 4) return false;
        int sum = matchsticks.Sum();

        if (sum % 4 != 0) {
            return false;
        }

        int len = sum / 4;
        
        if (matchsticks.Any(num => num > len)) 
            return false;
        
        Array.Sort(matchsticks, (a, b) => b - a);

        int[] current = new int[4] { len, len, len, len };

        DFS(matchsticks, 0, current);

        return isSquare;
    }
    private void DFS(int[] nums, int start, int[] current) {
        if (current.All(num => num == 0)) isSquare = true;

        if (isSquare) return;

        var cur = nums[start];

        for (int j = 0; j < 4; j++) {
            if (current[j] - cur >= 0) {
                current[j] -= cur;
                DFS(nums, start + 1, current);
                current[j] += cur;
            }
        }
    }
}