 public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        return  nums.ToList().Where((c,i) => i % 2 == 0).Sum();;
    }
