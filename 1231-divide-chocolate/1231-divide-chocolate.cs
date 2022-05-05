public class Solution {
    public int MaximizeSweetness(int[] sweetness, int k) {
        int left = Int32.MaxValue, right = 0;
        foreach(int sweet in sweetness)
        {    
            left = Math.Min(left, sweet); 
            right += sweet;
        }
        
        while(left < right)
        {
            int mid = left + (right - left) / 2;
            int chunk = CanCutNums(sweetness, k, mid);
            
            if(chunk > k + 1)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;        
            }
        }
        return left;
    }
    private int CanCutNums(int[] sweetness, int k, int totalSweetness)
    {
        int chunk = 1, sweetnessSum = 0;
        foreach(var sweet in sweetness)
        {
            if(sweetnessSum + sweet > totalSweetness)
            {
                chunk++;
                sweetnessSum = 0;
            }
            else
                sweetnessSum += sweet;
        }
        
        return chunk;
    }
}