public int[][] Transpose(int[][] A) {
        int rowCount = A.Length;
        int columnCount = A[0].Length;
        int[][] transposed = new int[columnCount][];
        
    if (rowCount == columnCount)
    {
        transposed = A;
        for (int i = 1; i < rowCount; i++)
        {
            for (int j = 0; j < i; j++)
            {
                int temp = transposed[i][j];
                transposed[i][j] = transposed[j][i];
                transposed[j][i] = temp;
            }
        }
    }
    else
    {
        for (int column = 0; column < columnCount; column++)
        {
            transposed[column] = new int[rowCount];
            for (int row = 0; row < rowCount; row++)
            {
                transposed[column][row] = A[row][column];
            }
        }
    }
    return transposed;
}
