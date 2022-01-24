 public bool DetectCapitalUse(string word) {
     
          if(word.Length < 1)
            return true;
          else if(word == word.ToUpper())
            return true;
          else if(word == word.ToLower())
            return true;
          else if(char.IsUpper(word[0]) && word.Substring(1,word.Length - 1) == word.Substring(1,word.Length - 1).ToLower())
            return true;
          else
            return false;
    }
//Another solution
public class Solution {
    public bool DetectCapitalUse(string word) {
        if(word == null || word.Length == 0)
            return true;
        
        if(word == word.ToUpper() || word == word.ToLower())
                return true;
        
        int firstcharval = (int)word[0];
        if(firstcharval >= 65 && firstcharval < 97)
        {
            if(word.Substring(1,word.Length - 1) == word.Substring(1,word.Length - 1).ToLower())
                return true;
            else
                return false;
        }
        else
            return false;
    }
}
