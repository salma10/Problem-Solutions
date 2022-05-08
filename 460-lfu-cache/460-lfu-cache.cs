public class LFUCache {
    int dataCapacity;
    int count;
    Dictionary<int, int> data;
    SortedDictionary<int, LinkedList<int>> dataCount;
    Dictionary<int, int> counts;
    
    public LFUCache(int capacity) {
        dataCapacity = capacity;
        count = 0;
        data = new Dictionary<int, int>();
        dataCount = new SortedDictionary<int, LinkedList<int>>();
        counts = new Dictionary<int, int>();
    }
    
    public int Get(int key) 
    {
       if(!data.ContainsKey(key))
         return -1;
       int currCount = counts[key];

       dataCount[currCount].Remove(key);
        if(dataCount[currCount].Count == 0)
            dataCount.Remove(currCount);
       counts[key]++;
       if(!dataCount.ContainsKey(currCount + 1))
          dataCount[currCount + 1] = new LinkedList<int>();
       dataCount[currCount + 1].AddLast(key);
       return data[key];
    }
    
    public void Put(int key, int value) 
    {
        if(dataCapacity <= 0)
            return;
        if(!data.ContainsKey(key))
        {
            count++;
            if(dataCapacity < count)
            {
                int minCount = dataCount.First().Key;
                LinkedList<int> currList = dataCount[minCount]; 
                int minKey = currList.First.Value;
                dataCount[minCount].Remove(minKey);
                if(dataCount[minCount].Count == 0)
                    dataCount.Remove(minCount);
                data.Remove(minKey);
                counts.Remove(minKey);
                count--;
            }

            if(!dataCount.ContainsKey(1))
                dataCount[1] = new LinkedList<int>();
           
          dataCount[1].AddLast(key);
          counts[key] = 1;
        }
        else
        {
            int currKeyCount = counts[key];
            dataCount[currKeyCount].Remove(key);
            if(dataCount[currKeyCount].Count == 0)
                dataCount.Remove(currKeyCount);
            if(!dataCount.ContainsKey(currKeyCount + 1))
                dataCount[currKeyCount + 1] = new LinkedList<int>();
            dataCount[currKeyCount + 1].AddLast(key);
            counts[key] = currKeyCount + 1;
        }
        data[key] = value;
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */