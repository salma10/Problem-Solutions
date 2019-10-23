/*
Given scores of N athletes, find their relative ranks and the people with the top three highest scores, who will be awarded medals: "Gold Medal", "Silver Medal" and "Bronze Medal".
*/

    public string[] FindRelativeRanks(int[] nums) {
        
        string[] result = new string[nums.Length];
        int[] res = new int[nums.Length];
        
        Array.Copy(nums, res, nums.Length);
        
        Array.Sort(res);
        Array.Reverse(res);
        
        for(int i = 0; i < res.Length; i++)
        {
            int pos = Array.IndexOf(nums, res[i]);
            if(i == 0)
            {
                result[pos] = "Gold Medal";
            }
            else if(i == 1)
            {
                result[pos] = "Silver Medal";
            }
            else if(i == 2)
            {
                result[pos] = "Bronze Medal";
            }
            else
            {
                result[pos] = (i + 1).ToString();
            }
        }
        return result;
    }
