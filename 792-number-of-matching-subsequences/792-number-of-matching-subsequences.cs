public class Solution {
    public int NumMatchingSubseq(string s, string[] words) {
        if(words == null || words.Length == 0)
            return 0;
        
        Queue<(string word, int idx)>[] queue = new Queue<(string word, int idx)>[26];
        for(int i = 0; i < 26; i++)
            queue[i] = new Queue<(string word, int idx)>();
        
        foreach(var word in words)
            queue[word[0] - 'a'].Enqueue((word, 0));
        
        int cnt = 0;
        foreach(var c in s)
        {
            var currQueue = queue[c - 'a'];
            int size = currQueue.Count;
            for(int i = 0; i < size; i++)
            {
                var curr = currQueue.Dequeue();
                curr.idx++;
                if(curr.idx == curr.word.Length)
                    cnt++;
                else
                    queue[curr.word[curr.idx] - 'a'].Enqueue((curr.word, curr.idx));
            }
        }
        
        return cnt;
    }
}