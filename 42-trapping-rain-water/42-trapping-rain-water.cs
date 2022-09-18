public class Solution {
    public int Trap(int[] height) {
        
        if (height.Length == 0) 
             return 0; 
        
        int left = 0, right = height.Length - 1; 
        int leftMax = 0, rightMax = 0; 
        int amountOfTrappedWater = 0; 
        
        while (left < right) {
            
            if (height[left] > leftMax) 
                leftMax = height[left]; 
            
            if (height[right] > rightMax) 
                rightMax = height[right];
            
            if (leftMax < rightMax) 
            {
                amountOfTrappedWater += Math.Max(0, leftMax - height[left]); 
                left++; 
            } 
            else 
            {
                amountOfTrappedWater += Math.Max(0, rightMax - height[right]); 
                right--; 
            }
        }
        return amountOfTrappedWater; 
    }
}