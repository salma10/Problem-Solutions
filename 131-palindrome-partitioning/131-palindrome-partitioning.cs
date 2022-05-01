public class Solution {
    public IList<IList<string>> Partition(string s) {
        List<IList<string>> result = new List<IList<string>>();
        DFS(0, result, new List<string>(), s);
        return result;
    }
     private void DFS(int start, List<IList<string>> result, List<string> currentList, String s) {
        if (start >= s.Length)
            result.Add(new List<string>(currentList));
        for(int end = start; end < s.Length; end++) 
        {
            if (IsPalindrome(s, start, end)) 
            {
                currentList.Add(s.Substring(start, end - start + 1));
                DFS(end + 1, result, currentList, s);
                currentList.RemoveAt(currentList.Count - 1);
            }
        }
    }

    private bool IsPalindrome(string s, int low, int high) {
        while (low < high)
        {
            if (s[low++] != s[high--]) 
                return false;
        }
        return true;
    }
}