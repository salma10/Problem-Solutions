public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        IList<int> result = new List<int>();
        int count = matrix.Length * matrix[0].Length;
        int row = 0, col = 0, rowMax = matrix.Length - 1, colMax = matrix[0].Length - 1;
        int rowMin = 1, colMin = 0;
        bool rowIncrease = false;
        bool rowDecrease = false;
        bool colIncrease = true;
        bool colDecrease = false;
        while(count > 0)
        {
            while(colIncrease && count > 0)
            {
                if(col > colMax)
                {
                    colIncrease = false;
                    rowIncrease = true;
                    row++;
                    colMax--;
                    col--;
                }
                else
                {
                    result.Add(matrix[row][col]);
                    col++;
                    count--;
                }
            }
            while(rowIncrease && count > 0)
            {
                if(row > rowMax)
                {
                    rowIncrease = false;
                    colDecrease = true;
                    col--;
                    rowMax--;
                    row--;
                }
                else
                {
                    result.Add(matrix[row][col]);
                    row++;
                    count--;
                }
            }
            while(colDecrease && count > 0)
            {
                if(col < colMin)
                {
                    colDecrease = false;
                    rowDecrease = true;
                    col++;
                    colMin++;
                    row--;
                }
                else
                {
                    result.Add(matrix[row][col]);
                    col--;
                    count--;
                }
            }
            
            while(rowDecrease && count > 0)
            {
                if(row < rowMin)
                {
                    rowDecrease = false;
                    colIncrease = true;
                    row++;
                    rowMin++;
                    col++;
                }
                else
                {
                    result.Add(matrix[row][col]);
                    row--;
                    count--;
                }
            }
        }
        return result;
    }
}