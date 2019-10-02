public int MaxNumberOfBalloons(string text) {
        
        int[] alphabet = new int[26];
        
        for(int i = 0; i < text.Length; i++)
        {
            alphabet[text[i] - 'a']++;
        }
        
        alphabet['l' - 'a'] = alphabet['l' - 'a']/2;
        alphabet['o' - 'a'] = alphabet['o' - 'a']/2;
        
        string res_word = "balon";
        int min = int.MaxValue;
        int count = 0;
        
        foreach(char c in res_word)
        {
            if(min > alphabet[c - 'a'])
            {
                min = alphabet[c - 'a'];
            }
        }                             
        if(min > 0 && min != int.MaxValue)
        {
            count = min;
        }        
        return count;     
    }
