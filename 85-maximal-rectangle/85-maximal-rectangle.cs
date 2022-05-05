public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int max = 0;
        int[] heights = new int[n];
        Stack<int> s = new Stack<int>();
        
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
                heights[j] = matrix[i][j] == '0' ? 0 : heights[j] + 1;
            
            for(int j = 0; j < n+1; j++)
            {
                int h = j == n ? 0 : heights[j];
                if(s.Count == 0 || heights[s.Peek()] < h)
                {
                    s.Push(j);
                } 
                else 
                {
                    int mid = s.Pop();
                    int left = s.Count == 0 ? -1 : s.Peek();
                    max = Math.Max(max, heights[mid] * (j-- - left - 1));
                }
            }
            s.Pop();
        }        
        return max;
    }
}