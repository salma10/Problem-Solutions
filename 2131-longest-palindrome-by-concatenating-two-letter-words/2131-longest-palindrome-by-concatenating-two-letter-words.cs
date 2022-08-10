public class Solution {
    public int LongestPalindrome(string[] words) {
        HashSet<string> sameSet = new HashSet<string>();
        Dictionary<string, int> diffDic = new Dictionary<string, int>();

        int count = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i][0] == words[i][1])
            {
                if (sameSet.Contains(words[i]))
                {
                    sameSet.Remove(words[i]);
                    count++;
                }
                else
                {
                    sameSet.Add(words[i]);
                }
            }
            else
            {
                if (diffDic.ContainsKey(words[i]))
                {
                    diffDic[words[i]]++;
                }
                else
                {
                    string opposite = string.Concat(words[i].Reverse());
                    if (diffDic.ContainsKey(opposite))
                    {
                        diffDic[opposite]--;
                        count++;

                        if (diffDic[opposite] == 0)
                        {
                            diffDic.Remove(opposite);
                        }
                    }
                    else
                    {
                        diffDic.Add(words[i], 1);
                    }
                }
            }
        }

        return (count * 2  + (sameSet.Count > 0 ? 1 : 0)) * 2;
    }
}