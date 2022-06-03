public class NumMatrix {
    private int[,] rangeSum;
    public NumMatrix(int[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length;
        rangeSum = new int[m + 1, n + 1];
        for(int i = 1; i < m + 1; i++)
        {
            for(int j = 1; j < n + 1; j++)
            {
                rangeSum[i, j] = rangeSum[i, j - 1] + rangeSum[i - 1, j] - rangeSum[i - 1, j - 1] + matrix[i - 1][j - 1];
            }
        } 
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        return rangeSum[row2 + 1, col2 + 1] - rangeSum[row1, col2 + 1] - rangeSum[row2 + 1, col1] + rangeSum[row1, col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */