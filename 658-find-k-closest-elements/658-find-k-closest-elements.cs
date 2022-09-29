public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        List<int> res = new List<int>();
        if(arr == null || arr.Length == 0)
            return res;
        
        int left = 0, right = arr.Length - k;
        while(left < right)
        {
            int mid = (right - left) / 2 + left;
            
            if(x - arr[mid] <= arr[mid + k] - x)
                right = mid;
            else
                left = mid + 1;
        }
               
        int i = left;
        while(k > 0)
        {
            res.Add(arr[i]);
            i++;
            k--;
        }

        return res;
    }
}