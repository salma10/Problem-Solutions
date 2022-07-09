public class Solution {
    public int MaxResult(int[] nums, int k) {
        if(nums == null || nums.Length == 0)
            return 0;
        
        int[] scores = new int[nums.Length];
        LinkedList<int> monoQueue = new LinkedList<int>();
        scores[0] = nums[0];
        monoQueue.AddLast(0);
        
        for(int i = 1; i < nums.Length; i++)
        {     
            while(monoQueue.Count > 0 && monoQueue.First.Value < i - k)
                monoQueue.RemoveFirst();
                       
            scores[i] = nums[i] + scores[monoQueue.First.Value];
            
            while(monoQueue.Count > 0 && scores[monoQueue.Last.Value] < scores[i])
                monoQueue.RemoveLast();
            
            monoQueue.AddLast(i);
        }
        
        return scores[nums.Length - 1];
    }
}