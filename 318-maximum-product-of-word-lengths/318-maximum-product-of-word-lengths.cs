public class Solution {
    public int MaxProduct(string[] words) {
         int[] arr = new int[words.Length];
        for(int i = 0; i < words.Length; i++)
        {
            arr[i] = 0;
            foreach(var c in words[i])
                arr[i] |= 1 << c - 'a';
        }
        
        int res = 0;
        for(int i = 0; i < words.Length; i++)
        {
            for(int j = i + 1; j < words.Length; j++)
            {
                if((arr[i] & arr[j]) == 0)
                    res = Math.Max(res, words[i].Length * words[j].Length);
            }
        }
        
        return res;
    }
}