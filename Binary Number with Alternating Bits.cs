  public bool HasAlternatingBits(int n) {
        string binary = Convert.ToString(n, 2);
        
        if(binary.Length < 2)
            return true;
        else
        {
            for(int i = 0; i < binary.Length - 1; i++)
            {
                if(binary[i] == binary[i + 1])
                    return false;
            }
        }
        return true;
    }
