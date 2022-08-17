public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string[] codes = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        
        HashSet<string> hashs = new HashSet<string>();
        
        for(int i = 0; i < words.Count(); i++)
        {
            StringBuilder s = new StringBuilder();
            string temp = words[i];
            for(int j = 0; j < words[i].Length; j++)
            {
                s.Append(codes[temp[j] - 'a']);
            }
            hashs.Add(s.ToString());
        }
        return hashs.Count;
    }
}