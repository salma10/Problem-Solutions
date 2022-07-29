public class Solution {
    public int Search(int[] nums, int target) {
        
        if(nums == null || nums.Length == 0)
            return -1;
        
        int rotationIndex = SearchRotationIndex(nums);
        int left = 0, right = nums.Length - 1 ;
        
        if(target <= nums[nums.Length - 1])
        {
             left = rotationIndex;
             right = nums.Length - 1 ;
        }
        else
        {
            left = 0;
            right = rotationIndex - 1 ;
        }
        
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if(target == nums[mid])
            { 
                return mid; 
            }
            else if(target > nums[mid]) 
            { 
                left = mid + 1; 
            }
            else 
            { 
                right = mid - 1; 
            }
        }
        
        return -1;
    }
    
    public int SearchRotationIndex(int[] nums)
    {
        int left = 0, right = nums.Length - 1 ;
        int mid = left + (right - left) / 2;
        
        while(left <= right)
        {
             mid = (left + right) / 2;
            
            if(mid < nums.Length - 1 && nums[mid] > nums[mid + 1])
            { 
                return ++mid; 
            }
            else if(nums[mid] < nums[left]) 
            { 
                right = mid - 1; 
                
            }
            else 
            { 
                left = mid + 1; 
            }
        }
        
        return 0;
    }
}