/*
Given an arbitrary ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.

Each letter in the magazine string can only be used once in your ransom note.

Note:
You may assume that both strings contain only lowercase letters.
*/

 public bool CanConstruct(string ransomNote, string magazine) {       
        char[] ran = ransomNote.ToCharArray();
        char[] mag = magazine.ToCharArray();     
        List<char> magL = mag.ToList();
        
        for(int i = 0; i < ran.Length; i++)
        {
            int pos = magL.FindIndex(a => a == ran[i]);
            if(pos <= -1)
            {
                return false;
            }
            else
            {
                magL.RemoveAt(pos);
            }
        }
    }

//Another solution
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
