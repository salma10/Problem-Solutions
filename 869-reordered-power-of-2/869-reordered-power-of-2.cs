public class Solution {
    public bool ReorderedPowerOf2(int n) {
        int[] target = ToCountMap(n);
        for(int i = 0; i < 31; i++)
        {
            int curr = (int)Math.Pow(2, i);
            if(target.SequenceEqual(ToCountMap(curr))) 
                return true;
        }
        return false;
    }
    private int[] ToCountMap(int n)
    {
        int[] map = new int[10];
        while(n != 0)
        {
            map[n % 10]++;
            n /= 10;
        }
        return map;
    }
}