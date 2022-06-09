public class Solution {
    public int CountOdds(int low, int high) {
        if(low % 2 == 0)
            return (high - low + 1) / 2;
        else 
            return (high - low + 2) / 2;
    }
}