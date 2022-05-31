public class Solution {
    public bool HasAllCodes(string s, int k) {
        HashSet<int> hset = new HashSet<int>();
        int i = s.Length-1;
        int j = i;
        int num = 0;
        while (i >= 0) 
        {
            num += (s[i] == '1' ? (1 << (j-i)) : 0);
            if (j-i+1 == k) 
            {
                hset.Add(num);
                num >>= 1;
                j--;
            }
            i--;
        }
        return hset.Count == (1 << k);
    }
}