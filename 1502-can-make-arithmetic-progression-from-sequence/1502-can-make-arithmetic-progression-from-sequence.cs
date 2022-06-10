public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int diff = arr[1] - arr[0];
        for(int index = 2; index < arr.Length; index++)
        {
            if(diff != arr[index] - arr[index - 1])
                return false;
        }
        return true;
    }
}