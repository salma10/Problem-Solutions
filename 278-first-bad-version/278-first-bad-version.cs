/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        
        if(n == 0)
            return 0;
        
        int left = 1, right = n;
       
        while(left < right)
        {
            int mid = left + (right - left) / 2;
            if(IsBadVersion(mid)) 
            { 
                right = mid; 
                
            }
            else 
            { 
                left = mid + 1; 
            }
        }
        return left;
    }
}