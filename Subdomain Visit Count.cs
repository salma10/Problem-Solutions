public IList<string> SubdomainVisits(string[] cpdomains) {
        
        Dictionary<string, int> hash = new Dictionary<string, int>();
        IList<string> result = new List<string>();
        for(int i = 0; i < cpdomains.Length; i++)
        {
             var temp = cpdomains[i].Split(' ');
             var Leng = temp[1].Split('.');
            int count = Convert.ToInt32(temp[0]);
            String cur = "";
            for (int j = Leng.Length - 1; j >= 0; --j) {
                cur = Leng[j] + (j < Leng.Length - 1 ? "." : "") + cur;
                if (hash.TryGetValue(cur, out int val))
                {
                    hash[cur] = val + count;
                }
                else
                {
                    hash.Add(cur, count);
                }
            }
        }
        
        foreach (KeyValuePair<string, int> pair in hash)
        {
            result.Add(pair.Value + " " +pair.Key);           
        }
        
       return result; 
    }
