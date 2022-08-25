public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> magazineDict = new Dictionary<char,int>();
        
        for(int i = 0; i < magazine.Length; i++)
        {
            if(magazineDict.ContainsKey(magazine[i]))
                magazineDict[magazine[i]]++;
            else
               magazineDict[magazine[i]] = 1; 
        }
        
        for(int i = 0; i < ransomNote.Length; i++)
        {
            if(magazineDict.ContainsKey(ransomNote[i]) && magazineDict[ransomNote[i]] > 0)
                magazineDict[ransomNote[i]]--;
            else
               return false;
        }
        
        return true;
    }
}