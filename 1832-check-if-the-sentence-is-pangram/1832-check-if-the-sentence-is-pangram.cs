public class Solution {
    public bool CheckIfPangram(string sentence) {
        HashSet<char> charSet = new HashSet<char>();
        
        for(int i = 0; i < sentence.Length; i++)
        {
            charSet.Add(sentence[i]);
        }
        
        return charSet.Count == 26;
    }
}