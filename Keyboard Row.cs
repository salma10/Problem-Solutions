public string[] FindWords(string[] words) {
        List<string>result = new List<string>();

        for(int i = 0; i < words.Length; i++)
        {
            bool res = false;
            if(res == false)
            {
                res = words[i].ToUpper().All("QWERTYUIOP".Contains);
            }
            if(res == false)
            {
                res = words[i].ToUpper().All("ASDFGHJKL".Contains);
            }
            if(res == false)
            {
                res = words[i].ToUpper().All("ZXCVBNM".Contains);
            }
            
            if(res == true)
            {
                result.Add(words[i]);
            }
        }
        return result.ToArray();
    }
