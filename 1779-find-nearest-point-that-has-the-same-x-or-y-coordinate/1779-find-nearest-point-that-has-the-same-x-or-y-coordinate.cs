public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
        int minDistance = Int32.MaxValue;
        int pos = -1;
        for(int index = 0; index < points.Length; index++)
        {
            if(x == points[index][0] || y == points[index][1])
            {
                int dist = Math.Abs(points[index][0] - x) + Math.Abs(points[index][1] - y);
                if(minDistance > dist)
                {
                    minDistance = dist;
                    pos = index;
                }               
            }                
        }
        return pos;
    }
}