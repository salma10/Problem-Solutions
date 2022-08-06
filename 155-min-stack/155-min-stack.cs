public class MinStack {
Stack<int> Data = new Stack<int>();
Stack<int> Min = new Stack<int>();

public void Push(int x) {
    Data.Push(x);
    
    if(Min.Count() == 0||x<Min.Peek())
        Min.Push(x);
    else 
        Min.Push(Min.Peek());
}

public void Pop() {
    if(Data.Count() == 0)
        return;
    Data.Pop();
    Min.Pop();
}

public int Top() {
    if(Data.Count() != 0)
        return Data.Peek();
    else
       return 0;
}

public int GetMin() {
    if(Min.Count() != 0)
        return Min.Peek();
    else
       return 0;
}
}


/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */