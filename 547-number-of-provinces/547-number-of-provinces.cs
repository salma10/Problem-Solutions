public class Solution {
    public int FindCircleNum(int[][] isConnected) {      
        int n =  isConnected.Length;
        int[] root = new int[n];
        int[] rank = new int[n];
        int count = n;
        
        for(int i = 0; i < n; i++)
        {
            root[i] = i;
            rank[i] = 1;
        }
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(isConnected[i][j] == 1)
                    count = Union(i, j, count, root, rank);
            }
        }
        return count;
    }
    
    int Find(int idx, int[] root) 
    {
        if (idx == root[idx]) {
            return idx;
        }
        return root[idx] = Find(root[idx], root);
    }

    private int Union(int x, int y, int count, int[] root, int[] rank) 
    {
        int rootX = Find(x, root);
        int rootY = Find(y, root);
        if (rootX != rootY) {
            if (rank[rootX] > rank[rootY]) {
                root[rootY] = rootX;
            } else if (rank[rootX] < rank[rootY]) {
                root[rootX] = rootY;
            } else {
                root[rootY] = rootX;
                rank[rootX] += 1;
            }
            count--;
        }
        return count;
    }
   
}