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