public class LRUCache {
    public class Cache
    {
        public int CacheKey;
        public int CacheVal;
        public Cache(int key, int val)
        {
            CacheKey = key;
            CacheVal = val;
        }
    }
    
    public int Capacity = 0;
    public Dictionary<int, LinkedListNode<Cache>> dic = new Dictionary<int, LinkedListNode<Cache>>();
    public LinkedList<Cache> lruList = new LinkedList<Cache>();
    
    public LRUCache(int capacity) {
        this.Capacity = capacity;
    }
    
    public int Get(int key) {
        if(!dic.ContainsKey(key))
            return -1;
        
        var cache = dic[key];

        lruList.Remove(cache);
        lruList.AddFirst(cache);
        
        return cache.Value.CacheVal;
    }
    
    public void Put(int key, int value) {
        if(dic.ContainsKey(key))
        {
            dic[key].Value.CacheVal = value;

            var cache = dic[key];
            lruList.Remove(cache);
            lruList.AddFirst(cache);
        }
        else
        {   
            Cache cache = new Cache(key, value);
            dic.Add(key, new LinkedListNode<Cache>(cache));
            lruList.AddFirst(dic[key]);
            
            if(dic.Count > Capacity)
            {
                LinkedListNode<Cache> lastCache = lruList.Last;
                dic.Remove(lastCache.Value.CacheKey);
                lruList.Remove(lastCache);
            }  
        } 

    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */