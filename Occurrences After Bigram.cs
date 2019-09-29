 public string[] FindOcurrences(string text, string first, string second) {
        string[] split_str = text.Split(' ');
        List<string> result = new List<string>();
        
        for(int i = 1; i < split_str.Length - 1; i++)
        {
            if(split_str[i - 1] == first && split_str[i] == second)
                result.Add(split_str[i + 1]);
        }
        return result.ToArray();
    }
