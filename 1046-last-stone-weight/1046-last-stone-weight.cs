public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(new DescendingComparator());
        for(int index = 0; index < stones.Length; index++)
        {
            maxHeap.Enqueue(stones[index], stones[index]);
        }
        
        while(maxHeap.Count > 1)
        {
            int max = maxHeap.Dequeue();
            int seccondMax = maxHeap.Dequeue();

            if(max - seccondMax != 0)
                maxHeap.Enqueue(max - seccondMax, max - seccondMax);
        }
        return  maxHeap.Count == 0 ? 0 : maxHeap.Dequeue(); 
    }
    
    public class DescendingComparator : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }
}