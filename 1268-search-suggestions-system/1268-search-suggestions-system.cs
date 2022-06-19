public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)     {
        List<IList<string>> result = new List<IList<string>>();
        Array.Sort(products);
        Trie trie = new Trie();
        foreach(string word in products)
            trie.Add(word);
        
        TrieNode node = trie.root;
        
        foreach(char c in searchWord)
        {
            node = node?.children == null ? null : node.children.ContainsKey(c) ? node.children[c] : null;
            if(node == null)
                result.Add(new List<string>());
            else
                result.Add(node.words);
        }
        return result;
    }
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public List<string> words = new List<string>();
    }
    public class Trie
    {
        public TrieNode root = new TrieNode();
        public void Add(string word)
        {
            TrieNode curr = root;
            foreach(char c in word)
            {
                if(!curr.children.ContainsKey(c))
                    curr.children[c] = new TrieNode();
                curr = curr.children[c];
                if(curr.words.Count < 3)
                    curr.words.Add(word);
            }
        }
    }
}
