public class Solution {
    public int[] FindBall(int[][] grid) {
    int rows = grid.Length;
	int cols = grid[0].Length;
	int[] result = new int[cols];

	for (int j = 0; j < cols; j++)
	{
		int curr = j;
		for (int i = 0; i < rows; i++)
		{
			if (grid[i][curr] == 1)
			{
				if (curr == cols - 1 || grid[i][curr + 1] == -1)
				{
					result[j] = -1;
					break;
				}
				curr++;
			}
			else
			{
				if (curr == 0 || grid[i][curr - 1] == 1)
				{
					result[j] = -1;
					break;
				}
				curr--;
			}
		}

		if (result[j] == 0)
		{
			result[j] = curr;
		}
	}

	return result;
    }
}