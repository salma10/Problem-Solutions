public class MyHashSet {
     int[] hash;
    
    public MyHashSet() {
        hash = new int[1000000];        
    }
    
    public void Add(int key) {
            hash[key] = 1;
    }
    
    public void Remove(int key) {
            hash[key] = 0;
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        
        if(hash[key] == 1)
            return true;
        else
            return false;
    }
    
    
}
