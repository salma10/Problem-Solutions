public class Solution {
     int numSqTotalCount = int.MaxValue;

    public int NumSquares(int n)
    {
        int seed = (int)Math.Sqrt(n);

        numSquareRecursive(seed, n, 1);

        return numSqTotalCount==int.MaxValue?0:numSqTotalCount;
    }

    private void numSquareRecursive(int seed, int n, int count)
    {
        if(count> numSqTotalCount)
        {
            return;
        }

        for (int i = seed; i > 0; i--)
        {
            if (i * i <= n)
            {
                numSqTotalCount = i * i == n ? Math.Min(count, numSqTotalCount) : numSqTotalCount;
                numSquareRecursive(i, n - (i * i), count + 1);
            }
        }

    }
}