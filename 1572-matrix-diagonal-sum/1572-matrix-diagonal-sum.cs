public class Solution {
    public int DiagonalSum(int[][] mat) {
        int sum = 0;
        int row = 0;
        int col = 0;
        int len = mat.Length;
        
        while(row < len && col < len)
        {
            sum += mat[row][col];
            row++;
            col++;
        }
        row = 0;
        col = len - 1;
        while(row < len && col >= 0)
        {
            sum += mat[row][col];
            row++;
            col--;
        }

        if(len % 2 == 1)
        {
            int half = len / 2;
            sum -= mat[half][half];
        }
        return sum;
    }
}