public class MyHashMap {
    
    int[] hash;
    public MyHashMap() {
       hash = new int[1000000];
        for (int i = 0; i < 1000000; i++) {
            hash[i] = -1;
        }
    }
    
    public void Put(int key, int value) {        
             hash[key] = value;
    }
    
   
    public int Get(int key) {   
        
        if (key < 0 || key > 1000001)
                return -1; 
        
          return hash[key];        
    }
    
    public void Remove(int key) {
        hash[key] = -1; 
    }
}

//Another solution
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

