public int TitleToNumber(string s) {
        
        char[] s1 = s.ToCharArray();
        Array.Reverse(s1);
        int res = 0;
        
        for(int i = 0; i < s1.Length; i++)
        {
            res = res + (int)(Math.Pow(26, i) * (s1[i] - 64));
        }
        
        return res;
    }
