public class RecentCounter {

    private Queue<int> count;
    
    public RecentCounter() {
        count = new Queue<int>();
    }
    
    public int Ping(int t) {
        
        count.Enqueue(t);
        
        while(count.Peek() < t - 3000)
            count.Dequeue();
        
        return count.Count();
        
        
    }
}
