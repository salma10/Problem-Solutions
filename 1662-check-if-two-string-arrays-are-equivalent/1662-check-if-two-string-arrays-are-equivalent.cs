public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        for(int i = 0; i < word1.Length; i++)
        {
            sb1.Append(word1[i]);
        }
        for(int i = 0; i < word2.Length; i++)
        {
            sb2.Append(word2[i]);
        }
        return sb1.ToString() == sb2.ToString();
    }
}