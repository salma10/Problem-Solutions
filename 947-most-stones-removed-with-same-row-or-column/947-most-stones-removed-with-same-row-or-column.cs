public class Solution {
    int cnt=0;
    
    public int RemoveStones(int[][] stones) {
        Dictionary<string,string> dict=new Dictionary<string,string>();

        foreach(var s in stones)
        {
            var str=s[0]+" "+s[1];
            dict.Add(str,str);
        }
        foreach(var s1 in stones)
        {
            var ss1=s1[0]+" "+s1[1];
            foreach(var s2 in stones)
            {
                if(s1[0]==s2[0]||s1[1]==s2[1])
                {
                    var ss2=s2[0]+" "+s2[1];
                    union(dict,ss1,ss2);
                }
            }
        }
        return cnt;
    }
    public void union(Dictionary<string,string> dict,string s1,string s2)
    {
        string x=find(dict,s1);
        string y=find(dict,s2);
        if(!x.Equals(y))
        {
            dict[x]=y;
            cnt++;
        }
    }
    public string find(Dictionary<string,string> dict,string s)
    {
        if(dict[s]==s)
            return s;
        dict[s]=find(dict,dict[s]);
        return dict[s];
    }
}