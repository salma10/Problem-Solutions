public class MyStack {

     Queue stack;
     int last;
    /** Initialize your data structure here. */
    public MyStack() {
        stack = new Queue();
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        stack.Enqueue(x);
        last = x;
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        object first = stack.Peek();
        object current = null;
        while (true) 
        {
            current = stack.Dequeue();
            if (stack.Count == 0 || stack.Peek() == first)
            {
                break;
            }
            last = (int)current;
            stack.Enqueue(current);
       }        
       return (int)current;
    }
    
    /** Get the top element. */
    public int Top() {
        return last;
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return stack.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */