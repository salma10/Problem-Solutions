public class Solution {
    public int MaximalSquare(char[][] matrix) {
        
        if( matrix.Length == 0)
            return 0;
        
        int result = 0;
        int[][] Map = new int[matrix.Length][];
        
        for(int i = 0; i < matrix.Length; i++)
        {
            Map[i] = new int[matrix[0].Length] ;
            Map[i][0] = matrix[i][0] - '0';
            result = Math.Max(Map[i][0], result);
        }  
        for(int i = 0; i < matrix[0].Length; i++)
        {
            Map[0][i] = matrix[0][i]  - '0';
            result = Math.Max(Map[0][i], result);
        }            
        
        for(int i = 1; i < Map.Length; i++)
        {
            for(int j = 1; j < Map[i].Length; j++)
            {
                if(matrix[i][j] == '1')
                {
                    Map[i][j] = Math.Min(Math.Min(Map[i][j - 1], Map[i - 1][j]), Map[i - 1][j - 1]) + 1;
                }
               result = Math.Max(result, Map[i][j]);
            }
        }
        
        return result * result;
    }
}