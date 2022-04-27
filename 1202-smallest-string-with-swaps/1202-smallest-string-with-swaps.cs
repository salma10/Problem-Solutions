public class Solution {
    public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs) {
            UnionFind unf = new UnionFind(s.Length);
            foreach(var pair in pairs)
            {
                unf.Union(pair[0], pair[1]);
            }

            Dictionary<int, List<char>> dic = new Dictionary<int, List<char>>();
            for(int i = 0; i < s.Length; i++)
            {
                int root = unf.Find(i);
                if (!dic.ContainsKey(root))
                {
                    dic.Add(root, new List<char>());
                }

                dic[root].Add(s[i]);
            }

            StringBuilder sb = new StringBuilder();

            foreach(var item in dic)
            {
                item.Value.Sort();
            }

            for(int i = 0; i < s.Length; i++)
            {
                List<char> chars = dic[unf.Find(i)];
                sb.Append(chars[0]);
                chars.RemoveAt(0);
            }

            return sb.ToString();
    }
    public class UnionFind {
    private int[] root;
    private int[] rank;
    
    public UnionFind(int size)
    {
        this.root = new int[size];
        this.rank = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            this.root[i] = i;
            this.rank[i] = 1;
        }
    }
    
    public int Find(int x)
    {
        if (x == this.root[x])
        {
            return x;
        }
        
        return this.root[x] = this.Find(this.root[x]);
    }
    
    public void Union(int x, int y)
    {
        int rootX = this.Find(x);
        int rootY = this.Find(y);
        
        if (rootX != rootY)
        {
            if (this.rank[rootX] < this.rank[rootY])
            {
                this.root[rootX] = rootY;
            }
            else if (this.rank[rootY] < this.rank[rootX])
            {
                this.root[rootY] = rootX;
            }
            else
            {
                this.root[rootY] = rootX;
                this.rank[rootX]++;
            }
        }
    }
  }
}