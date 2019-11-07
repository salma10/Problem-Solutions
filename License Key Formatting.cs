/*
You are given a license key represented as a string S which consists only alphanumeric character and dashes. The string is separated into N+1 groups by N dashes.

Given a number K, we would want to reformat the strings such that each group contains exactly K characters, except for the first group which could be shorter than K, but still must contain at least one character. Furthermore, there must be a dash inserted between two groups and all lowercase letters should be converted to uppercase.

Given a non-empty string S and a number K, format the string according to the rules described above.
*/

 public string LicenseKeyFormatting(string S, int K) {
        
        StringBuilder sb = new StringBuilder();
        int charLen = 0;
        for (int i = S.Length - 1; i >= 0; i--)
        {
            if (S[i] != '-')
            {
                if (charLen > 0 && charLen % K == 0)
                {
                    sb.Append('-');
                }
                sb.Append(Char.ToUpper(S[i]));
                charLen++;
            }
        }
        
        char[] chars = sb.ToString().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
