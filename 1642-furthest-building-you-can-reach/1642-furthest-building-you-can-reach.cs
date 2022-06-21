public class Solution {
    public int FurthestBuilding(int[] heights, int bricks, int ladders) {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        for(int index = 1; index < heights.Length; index++)
        {
            if(heights[index] > heights[index - 1])
            {
               if(minHeap.Count < ladders)
               {
                  minHeap.Enqueue(heights[index] - heights[index - 1], heights[index] - heights[index - 1]);
               }
               else if(minHeap.Count > 0 && minHeap.Count == ladders && minHeap.Peek() < heights[index] - heights[index - 1]) 
               {
                   int current = minHeap.Dequeue();
                   minHeap.Enqueue(heights[index] - heights[index - 1], heights[index] - heights[index - 1]);
                   bricks -= current;
               }
               else
                {
                    bricks -= (heights[index] - heights[index - 1]);
                }
            }
           
            // if(minHeap.Count == ladders && bricks == 0)
            //     return index;
            if(minHeap.Count == ladders && bricks < 0)
                return index - 1;
        }
        return heights.Length - 1;
    }
}