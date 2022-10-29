public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = strs[0];
        for(int i = 1; i < strs.Length; i++)
        {
            string current = strs[i];
            int k = 0;
            for(int j = 0; j < current.Length && k < result.Length; j++, k++)
            {
                if(current[j] != result[k])
                    break;
            }
            if(k == 0)
                return string.Empty;
            else
                result = result.Substring(0, k);
        }
        return result;
    }
}