public class Solution {
    public IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration)     {
        if(slots1.Length == 0 || slots2.Length == 0)
            return new List<int>();
        
        int slot1Pos = 0;
        int slot2Pos = 0;
        Array.Sort(slots1, (x, y) => x[0].CompareTo(y[0]));
        Array.Sort(slots2, (x, y) => x[0].CompareTo(y[0]));
        
        while(slot1Pos < slots1.Length && slot2Pos < slots2.Length)
        {
            int[] slot1Curr = slots1[slot1Pos];
            int[] slot2Curr = slots2[slot2Pos];
            
            if(slot1Curr[0] <= slot2Curr[0] && slot2Curr[0] < slot1Curr[1])
            {
                int start = slot2Curr[0];
                int end = slot2Curr[1] < slot1Curr[1] ? slot2Curr[1] : slot1Curr[1];
                if(end - start >= duration)
                    return new List<int>{start, start + duration};
            }
            else if(slot2Curr[0] <= slot1Curr[0] && slot1Curr[0] < slot2Curr[1])
            {
                int start = slot1Curr[0];
                int end = slot2Curr[1] < slot1Curr[1] ? slot2Curr[1] : slot1Curr[1];
                if(end - start >= duration)
                    return new List<int>{start, start + duration};
            }
            if(slot2Curr[1] < slot1Curr[1])
                slot2Pos++;
            else
                slot1Pos++;
        }
        return new List<int>();
    }
}