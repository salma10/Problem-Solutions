public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> result = new List<IList<string>>();
        Dictionary<string, List<string>> hash = new Dictionary<string, List<string>>();
        for(int i = 0; i < strs.Length; i++)
        {
            string temp = SortString(strs[i]);
            if(hash.ContainsKey(temp))
                hash[temp].Add(strs[i]);
            else
                hash[temp] = new List<string>{strs[i]};
        }
        
        foreach(var item in hash)
            result.Add(item.Value);
        return result;
    }
    
    private string SortString(string input)
    {
        int[] count = new int[26];
        for (int i = 0; i < input.Length; i++) 
            count[input[i] - 'a']++;
        
        StringBuilder  sb = new StringBuilder();
        for (int i = 0; i < 26; i++) {
            sb.Append('#');
            sb.Append(count[i]);
        }

        return sb.ToString();
    }
}