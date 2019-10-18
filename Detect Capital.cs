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
