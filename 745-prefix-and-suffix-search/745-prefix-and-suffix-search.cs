public class WordFilter {

    public class TrieNode
    {
        public TrieNode[] children;
        public int weight;
        public TrieNode()
        {
            children = new TrieNode[27];
        }
    }

    public TrieNode root;
    
    public WordFilter(string[] words) {
        
        root = new TrieNode();
        for(int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            string key = "{" + word;
            Insert(key, i);
            for(int j = 0; j < word.Length; j++)
            {
                key = word[word.Length - 1 - j] + key;
                Insert(key, i);
            }
        }     
    }
    
    public void Insert(string word, int weight)
    {
        TrieNode curr = root;
        foreach(char c in word)
        {
            if(curr.children[c - 'a'] == null)
                curr.children[c - 'a'] = new TrieNode();
            
            curr = curr.children[c - 'a'];
            curr.weight = Math.Max(curr.weight, weight);
        }
    }
    
    public int F(string prefix, string suffix) {
        
        TrieNode curr = root;
        string searchWord = suffix + "{" + prefix;
        foreach(var c in searchWord)
        {
            if(curr.children[c - 'a'] == null)
                return -1;
            
            curr = curr.children[c - 'a'];
        }
        return curr.weight;
    }
}

/**
 * Your WordFilter object will be instantiated and called as such:
 * WordFilter obj = new WordFilter(words);
 * int param_1 = obj.F(prefix,suffix);
 */