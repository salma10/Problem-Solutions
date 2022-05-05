public class Solution {
    public int[] FindPeakGrid(int[][] mat) {
        return FindAnyPeak(mat, 0, mat[0].Length - 1);
    }
    private int[] FindAnyPeak(int[][] mat, int start, int end)
    {
        if(start > end) return new int[]{-1, -1};

        int med = start + (end - start) / 2;
        
        int maxL = 0;
        int max = 0;
        int maxIndex = -1;
        int maxR = 0;

        for(int i = 0; i < mat.Length; i++)
        {
            if(med > start) maxL = Math.Max(maxL, mat[i][med - 1]);
            if(mat[i][med] > max)
            {
                max = mat[i][med];
                maxIndex = i;          
            }
            if(med < end) maxR = Math.Max(maxR, mat[i][med + 1]);
        }
        
        if(max > maxL && max > maxR)
        {
            return new int[]{maxIndex, med};
        }
        
        if(max > maxL)
        {
           return FindAnyPeak(mat, med + 1, end);
        }
        
        return FindAnyPeak(mat, start, med - 1);
    }
}