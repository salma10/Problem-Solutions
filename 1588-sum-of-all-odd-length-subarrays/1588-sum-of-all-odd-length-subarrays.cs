public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            int left = i + 1;
            int right = arr.Length - i;
            
            sum += (left * right + 1) / 2 * arr[i];
        }
        return sum;
    }
}