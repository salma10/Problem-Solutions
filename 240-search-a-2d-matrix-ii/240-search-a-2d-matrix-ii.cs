public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row = matrix.Length - 1;
        int col = 0;

        while (row >= 0 && col < matrix[0].Length) {
            if (matrix[row][col] > target) {
                row--;
            } else if (matrix[row][col] < target) {
                col++;
            } else {
                return true;
            }
        }

        return false;
    }
}