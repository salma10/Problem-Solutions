public int[,] MatrixReshape(int[,] nums, int r, int c) {        
        int rows = nums.GetLength(0);
        int columns = nums.GetLength(1);
        
        int res_row = 0;
        int res_col = -1;
        
        if(rows * columns != r * c)
            return nums;
        
        int[,] result = new int[r,c];    
        
        for(int k=0;k < rows;k++)
        {
            for(int l=0;l < columns;l++)
            {      
                res_col++;
                 if(res_col >= c)
                 {
                     res_col = 0;
                     res_row++;          
                 }                         
                
                result[res_row,res_col] = nums[k,l];                 
            }               
        }
         return result;   
    }

//Another solution of this problem
public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        
        int row = mat.Length;
        int col = mat[0].Length;
        int[][] result = new int[r][];
        int currRow = 0;
        int currCol = 0;
        int[] newRow = new int[c];
        
        
        if(row * col != r * c)
            return mat;
        
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                if(currCol < c)
                {
                    newRow[currCol] = mat[i][j];
                    currCol++;
                   // Console.WriteLine(mat[i][j]);
                }
                else
                {
                    result[currRow] = newRow;
                    newRow = new int[c];
                    currRow++;
                    currCol = 0;
                    newRow[currCol] = mat[i][j];
                    currCol++;
                }
            }
        }
        result[currRow] = newRow;
        return result;
    }
}
