public class Solution {
    public string RemoveDuplicates(string s, int k) {
        StringBuilder sb = new StringBuilder(s);
        Stack<int> counts = new Stack<int>();
        for (int i = 0; i < sb.Length; ++i) 
        {
            if (i == 0 || sb[i] != sb[i - 1]) 
            {
                counts.Push(1);
            } 
            else 
            {
                int incremented = counts.Pop() + 1;
                if (incremented == k) 
                {
                    sb.Remove(i - k + 1, incremented);
                    i = i - k;
                } 
                else 
                {
                    counts.Push(incremented);
                }
            }
        }
        return sb.ToString();
    }
}