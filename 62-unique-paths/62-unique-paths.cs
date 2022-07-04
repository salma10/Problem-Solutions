public class Solution {
    public int UniquePaths(int m, int n) {
        int[] result = new int[n];
        
         for(int  k = 0; k < n; k++)
            result[k] = 1;
        
        for(int  i = 1; i < m; i++)
        {
            int prevCell = 1;
            for(int  j = 1; j < n; j++)
            {
                int sum = prevCell + result[j];
                prevCell = sum;
                result[j] = sum;
            }
        }
        return result[n - 1];
    }
}