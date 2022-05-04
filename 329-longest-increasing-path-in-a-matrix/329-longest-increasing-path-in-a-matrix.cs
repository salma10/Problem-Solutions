public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        if (matrix.Length == 0 || matrix[0].Length== 0) 
          return 0; 
        
        int[,] dp = new int[matrix.Length, matrix[0].Length];
         
        int max = 0;
        
        for(int i=0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[0].Length; j++)
            {
                max = Math.Max(max, Traverse(matrix, i, j, dp));
            }
        }
        return (max == 0)? 1 : max + 1;
    }
    private int Traverse(int[][] matrix, int i, int j, int[,] dp)
    {  
        if (dp[i,j] != 0) 
        { 
            return (dp[i,j] == -1)? 0 : dp[i,j]; 
        }
        
        int count = -1;
        
        if (i > 0 && matrix[i][j] < matrix[i-1][j]) 
        { 
            count = 1 + Traverse(matrix, i-1, j, dp);  
        }
        if (i < matrix.Length-1 && matrix[i][j] < matrix[i+1][j]) 
        { 
            count = Math.Max(count, 1 + Traverse(matrix, i+1, j, dp));  
        }
        
        if (j > 0 && matrix[i][j] < matrix[i][j-1]) 
        { 
            count =  Math.Max(count, 1 + Traverse(matrix, i, j-1, dp));  
        }
        if (j < matrix[0].Length-1 && matrix[i][j] < matrix[i][j+1]) 
        { 
            count = Math.Max(count, 1 + Traverse(matrix, i, j+1, dp));  
        }
       
        dp[i,j] = count;
        
        return (count == -1)? 0 : count;
    }
}