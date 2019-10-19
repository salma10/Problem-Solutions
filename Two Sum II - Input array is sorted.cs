 public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
    int right = numbers.Length-1;
    while(left<right){
        while(left<right&&(numbers[left]+numbers[right])<target){
            left++;
        }
        while(left<right&&(numbers[left]+numbers[right])>target){
            right--;
        }
        if((numbers[left]+numbers[right])==target){
            return new int[2]{left+1,right+1};
        }
    }
    return new int[0]{};
    }
