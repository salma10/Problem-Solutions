public int HammingDistance(int x, int y) {
        
        string sx = Convert.ToString(x, 2);
        string sy = Convert.ToString(y, 2);
        int count = 0;
        if(sx.Length < sy.Length)
        {
            sx = sx.PadLeft(sy.Length, '0');
        }
        else
        {
            sy = sy.PadLeft(sx.Length, '0');
        }
      
        char[] sx1 = sx.ToCharArray();
        char[] sy1 = sy.ToCharArray();
        
        for(int i = 0; i < sx.Length; i++)
        {
            if(sx1[i] != sy1[i])
            {
                count++;
            }
        }
        return count;
    }
