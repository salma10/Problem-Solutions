public class Solution {
    public int[] MovesToStamp(string s, string t) {
        if(s == t)
            return new int[] { 0 };
        char[] SC = s.ToCharArray(), TC = t.ToCharArray();
        int sLen = SC.Length, tLen = TC.Length - sLen + 1, i, j;
        bool tDiff = true, sDiff;
        List<int> list = new();
        
        while(tDiff)
        {
            for(i = 0, tDiff = false; i < tLen; i++)
            {
                for(j = 0, sDiff = false; j < sLen; j++)
                {
                    if(TC[i + j] == '*')
                        continue;
                    else if(TC[i + j] != SC[j])
                        break;
                    else
                        sDiff = true;
                }
                if(j == sLen && sDiff)
                {
                    for(j = i, tDiff = true; j < sLen + i; j++)
                        TC[j] = '*';
                    list.Insert(0, i);
                }
            }
        }
        
        if(TC.Any(x => x != '*'))
            return new int[0];
        
        return list.ToArray();
    }
}