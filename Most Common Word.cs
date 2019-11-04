/*
Given a paragraph and a list of banned words, return the most frequent word that is not in the list of banned words.  It is guaranteed there is at least one word that isn't banned, and that the answer is unique.
Words in the list of banned words are given in lowercase, and free of punctuation.  Words in the paragraph are not case sensitive.  The answer is in lowercase.
*/

public string MostCommonWord(string paragraph, string[] banned) {
        
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        
         paragraph = paragraph.ToLower();
        
         paragraph = paragraph.Replace("!"," ");
         paragraph = paragraph.Replace("?"," ");
         paragraph = paragraph.Replace("''"," ");
         paragraph = paragraph.Replace("'"," ");
         paragraph = paragraph.Replace(","," ");
         paragraph = paragraph.Replace(";"," ");
         paragraph = paragraph.Replace("."," ");
        
        for(int i = 0; i < banned.Length; i++)
        {
            string pattern = String.Format(@"\b{0}\b", banned[i]);
            paragraph =  Regex.Replace(paragraph, pattern, "", RegexOptions.IgnoreCase);
        }
         paragraph = paragraph.Trim();

         string[] arr = paragraph.Split(' '); 
        
         foreach (string word in arr)
         {   
            if(word != " " && word != string.Empty) 
            {
                if (dictionary.ContainsKey(word))
                   dictionary[word] = dictionary[word] + 1; 
                else
                   dictionary[word] = 1;  
            }
         }
        
        return dictionary.OrderByDescending(x => x.Value).FirstOrDefault().Key;
    }
