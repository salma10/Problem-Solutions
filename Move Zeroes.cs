public void MoveZeroes(int[] nums) {
        
        int temp = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
        for (int j = i+1; j < nums.Length; j++)
        {
            if (nums[i] == 0 && nums[j] != 0)
            {
                temp = nums[i];

                nums[i] = nums[j];

                nums[j] = temp;
            }
        }
    }      
    }
//Another solution
public class Solution {
    public void MoveZeroes(int[] nums) {
        
        int pointZero = -1, pointNonZero = -1;
        int nonZeroElement = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0 && pointZero == -1)
            {
                pointZero = i;
                pointNonZero = -1;
            }
            else if(nums[i] != 0)
            {
                pointNonZero = i;
                nonZeroElement = nums[i];
            }
            if(pointZero != -1 && pointNonZero != -1)
            {
                nums[pointNonZero] = 0;
                nums[pointZero] = nonZeroElement;
                if(pointZero + 1 != nums.Length - 1 && nums[pointZero + 1] == 0)
                    pointZero = pointZero + 1;
                else
                    pointZero = pointNonZero;
                
                pointNonZero = -1;
            }
        }
    }
}
//Another solution
