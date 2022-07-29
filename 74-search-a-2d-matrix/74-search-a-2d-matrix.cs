public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        int maxColLength = matrix[0].Length;
        
        for(int i = 0; i < matrix.Length; i++)
        {
            if(matrix[i][0] <= target && matrix[i][maxColLength - 1] >= target)
            {
                int left = 0;
                int right = maxColLength - 1;
                
                while(left <= right)
                {
                    int mid = (left + right) / 2;
                    if(matrix[i][mid] == target)
                        return true;
                    else if(matrix[i][mid] < target)
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
            }
        }
        return false;
    }
}