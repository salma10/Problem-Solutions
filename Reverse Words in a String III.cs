public string ReverseWords(string s) {      
        return string.Join(" ", s.Split().Select(w => new string(w.ToCharArray().Reverse().ToArray())));       
    }
