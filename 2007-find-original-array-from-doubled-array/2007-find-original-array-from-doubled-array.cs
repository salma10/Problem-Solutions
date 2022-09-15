public class Solution {
    public int[] FindOriginalArray(int[] changed) {
        if(changed.Length % 2 == 1 || changed.Length < 2)
            return new int[]{};
        Array.Sort(changed);
        
        Dictionary<int, int> dic = new Dictionary<int, int>();
        
        for(int i = 0; i < changed.Length; i++)
        {
            dic.TryAdd(changed[i], 0);
            dic[changed[i]]++;
        }
        
        List<int> res = new List<int>();
        
        for(int i = 0; i< changed.Length; i++)
        {
            if(dic[changed[i]] > 0)
            {
                dic[changed[i]]--;
                if(!dic.ContainsKey(changed[i] * 2) || dic[changed[i]*2] == 0)
                    return new int[0];
                else
                    dic[changed[i] * 2]--;
                res.Add(changed[i]);
            }
            
        }
        
        return res.ToArray();
    }
}