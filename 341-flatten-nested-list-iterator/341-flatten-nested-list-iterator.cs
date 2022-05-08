/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {

    IList<NestedInteger> nestedList;
    Queue<int> queue;
    
    public NestedIterator(IList<NestedInteger> nestedList) {
        this.nestedList = nestedList;
        queue = new Queue<int>();
        AddToQueue(this.nestedList);
    }

    public void AddToQueue(IList<NestedInteger> nestedList)
    {
        int len=nestedList.Count;
        foreach(NestedInteger item in nestedList)
        {
            if(item.IsInteger())
                queue.Enqueue(item.GetInteger());
            else
            {
                IList<NestedInteger> temp = item.GetList();
                AddToQueue(temp);
            }
        }
    }

    public bool HasNext() {
        if(queue.Count>0)
            return true;
        return false;
    }

    public int Next() {
        return queue.Dequeue();
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */