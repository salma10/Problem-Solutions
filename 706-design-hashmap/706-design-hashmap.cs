public class MyHashMap {

    int[] hash;
    public MyHashMap() {
        hash = Enumerable.Repeat(-1, 1000001).ToArray();
    }
    
    public void Put(int key, int value) {
        hash[key] = value;
    }
    
    public int Get(int key) {
        return hash[key];
    }
    
    public void Remove(int key) {
        hash[key] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */