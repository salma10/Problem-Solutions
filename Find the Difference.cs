 public char FindTheDifference(string s, string t) {
        
        char[] q = s.ToCharArray();
        string Replace = string.Empty;
        char result = '0';
        for(int i = 0; i< s.Length; i++)
        {
            int Place = t.IndexOf(q[i]);
 t = t.Remove(Place,1).Insert(Place, Replace);
 
 }
      return t[0];
    }
