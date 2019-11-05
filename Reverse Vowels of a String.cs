/*
Write a function that takes a string as input and reverse only the vowels of a string.
*/

 public string ReverseVowels(string s) {
        
        char[] sArr = s.ToCharArray();
        List<char> vowel = new List<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(sArr[i] == 'a' || sArr[i] == 'e' || sArr[i] == 'i' || sArr[i] == 'o' || sArr[i] == 'u' || sArr[i] == 'A' || sArr[i] == 'E' || sArr[i] == 'I' || sArr[i] == 'O' || sArr[i] == 'U')
            {
                vowel.Add(sArr[i]);
            }
        }
        
        vowel.Reverse();
        
        for(int i = 0; i < sArr.Length; i++)
        {
            if(sArr[i] == 'a' || sArr[i] == 'e' || sArr[i] == 'i' || sArr[i] == 'o' || sArr[i] == 'u' || sArr[i] == 'A' || sArr[i] == 'E' || sArr[i] == 'I' || sArr[i] == 'O' || sArr[i] == 'U')
            {
                sArr[i] = vowel.FirstOrDefault();
                vowel.RemoveAt(0);
            }
        }
        s = new string(sArr);
        return s;
    }
