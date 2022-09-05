/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        if(root == null)
            return new List<IList<int>>();
        Queue<Node> levelList = new Queue<Node>();
        levelList.Enqueue(root);
        IList<IList<int>> result = new List<IList<int>>();
        
        while(levelList.Count > 0)
        {
            List<int> currentList = new List<int>();
            int count = levelList.Count;
            while(count > 0)
            {
                Node current = levelList.Dequeue();
                currentList.Add(current.val);
                foreach(Node child in current.children)
                {
                    levelList.Enqueue(child);
                }
                count--;
            }
            
            result.Add(currentList);
        }
        return result;
    }
}