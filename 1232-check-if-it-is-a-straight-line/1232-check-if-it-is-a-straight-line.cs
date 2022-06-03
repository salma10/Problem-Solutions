public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        
        if(coordinates.Length == 2)
            return true;
        
        long x1 = coordinates[1][0] - coordinates[0][0];
        long y1 = coordinates[1][1] - coordinates[0][1];
        
        for(int i = 2; i < coordinates.Length; i++)
        {
           long x2 = coordinates[i][0] - coordinates[0][0];
           long y2 = coordinates[i][1] - coordinates[0][1];
            
           if(x1 * y2 != x2 * y1)
               return false;
        }
       
        return true;
    }
}