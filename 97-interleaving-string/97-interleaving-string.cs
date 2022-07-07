public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        int s3Pos = s3.Length;
        int s2Pos = s2.Length;
        int s1Pos = s1.Length;
        if(s1Pos + s2Pos != s3Pos)
            return false;
        bool[,] dp = new bool[s1Pos + 1, s2Pos + 1];
       
        for(int i = 0; i <= s1Pos; i++)
        {
            for(int j = 0; j <= s2Pos; j++)
            {
                if(i == 0 && j == 0)
                    dp[i,j] = true;
                else if(i == 0)
                    dp[i,j] = dp[i,j - 1] && s2[j - 1] == s3[i + j - 1];
                else if(j == 0)
                    dp[i,j] = dp[i - 1,j] && s1[i - 1] == s3[i + j - 1];
                else
                    dp[i,j] = (dp[i,j - 1] && s2[j - 1] == s3[i + j - 1]) || (dp[i - 1,j] && s1[i - 1] == s3[i + j - 1]);
            }
        }
        return dp[s1Pos, s2Pos];
    }
}