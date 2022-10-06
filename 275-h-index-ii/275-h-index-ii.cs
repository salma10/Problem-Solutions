public class Solution {
    public int HIndex(int[] citations) {
        int len = citations.Length;
        int left = 0, right = len - 1;
        
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if(citations[mid] >= len - mid)
                right = mid - 1;
            else
                left = mid + 1;
        }
        return len - left;
    }
}

