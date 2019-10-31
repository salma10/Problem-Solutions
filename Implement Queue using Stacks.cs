/*
Implement the following operations of a queue using stacks.
push(x) -- Push element x to the back of queue.
pop() -- Removes the element from in front of queue.
peek() -- Get the front element.
empty() -- Return whether the queue is empty.
*/

public class MyQueue {

    Stack que;
    Stack temp_que;
    int first;
    /** Initialize your data structure here. */
    public MyQueue() {
        que = new Stack();
        temp_que = new Stack();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        if(que.Count == 0)
            first = x;
        que.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        int last;
        int count = que.Count;
        
        while(true)
        {
            if(count == 1)
            {
               last = (int)que.Pop();
               break; 
            }
                
            object data = que.Pop();
            first = (int)data;
            temp_que.Push(data); 
            count--;
        }
        count = temp_que.Count;
        while(true)
        {
            if(count == 0)
                break;
            object data = temp_que.Pop();
            que.Push(data); 
            count--;
        }
        
        return last;
    }
    
    /** Get the front element. */
    public int Peek() {
        return first;
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return que.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
