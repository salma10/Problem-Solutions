 public bool IsAnagram(string s, string t) {        
        if(s.Length != t.Length)
        {
            return false;
        }
        else
        {
            char[] s1 = s.ToCharArray();
        char[] t1 = t.ToCharArray();
        
        List<char> t2 = new List<char>();
        t2 = t1.ToList();
        
        for(int i = 0; i < s1.Length; i++)
        {
            if(pos > -1)
            {
                t2.RemoveAt(pos);
            }
        }
        
        if(t2.Count() > 0)
          return false;
          else
            return true;
        }
    }
