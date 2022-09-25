public class MyCircularQueue {
    Queue<int> numbers;
    int maxLength;
    int lastValue;
    
    public MyCircularQueue(int k) {
        numbers = new Queue<int>();
        maxLength = k;
    }
    
    public bool EnQueue(int value) {
        if(numbers.Count >= maxLength)
            return false;
        else
        {
            numbers.Enqueue(value);
            lastValue = value;
            return true;
        }
    }
    
    public bool DeQueue() {
         if(numbers.Count == 0)
            return false;
        else
        {
            numbers.Dequeue();
            return true;
        }
    }
    
    public int Front() {
        if(numbers.Count == 0)
            return -1;
        else
            return numbers.Peek();
    }
    
    public int Rear() {
        if(numbers.Count == 0)
            return -1;
        else
            return lastValue;
    }
    
    public bool IsEmpty() {
        if(numbers.Count == 0)
            return true;
        else
            return false;
            
    }
    
    public bool IsFull() {
         if(numbers.Count == maxLength)
            return true;
        else
            return false;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */