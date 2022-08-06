
public class Trie {
    
    private TrieNode root;

    /** Initialize your data structure here. */
    public Trie() {
        root = new TrieNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        
        TrieNode node = root;
        
        for(int i = 0; i < word.Length; i++)
        {
            if(!node.containsKey(word[i]))
            {
                node.put(word[i], new TrieNode());
            }
            
            node = node.get(word[i]);
        }
        
        node.setWord();
    }
    
    
    public TrieNode searchWord(string word)
    {
        TrieNode node = root;
        for(int i = 0; i < word.Length; i++)
        {
            if(node.containsKey(word[i]))
            {
                node = node.get(word[i]);
            }
            else
                return null;
        }
        return node;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        
        TrieNode node = searchWord(word);
        return node != null && node.getWord();
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        TrieNode node = searchWord(prefix);
        return node != null;
    }
}
public class TrieNode
{
    public bool isWord;
    public TrieNode[] childs = new TrieNode[26];
    
     public void put(char ch, TrieNode node) {
            childs[ch -'a'] = node;
        }
    
     public TrieNode get(char ch) {
            return childs[ch -'a'];
        }
    
    public bool containsKey(char ch) {
            return childs[ch -'a'] != null;
        }
    public void setWord() {
            isWord = true;
        }
    
        public bool getWord() {
            return isWord;
        }
    
}
/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */