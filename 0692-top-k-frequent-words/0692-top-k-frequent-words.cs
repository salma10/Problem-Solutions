public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        SortedDictionary<string, int> wordCount = new SortedDictionary<string, int>();
        for(int index = 0; index < words.Length; index++)
        {
            string currentWord = words[index];
            if(wordCount.ContainsKey(currentWord))
                wordCount[currentWord]++;
            else
                wordCount[currentWord] = 1;
        }
        List<string> result = new List<string>();
        foreach(KeyValuePair<string, int> item in wordCount.OrderByDescending(key => key.Value))
        {
            result.Add(item.Key);
            k--;
            if(k == 0)
                break;
        }
        return result;
    }
}