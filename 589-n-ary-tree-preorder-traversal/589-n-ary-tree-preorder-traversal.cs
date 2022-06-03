/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
         IList<int> ret = new List<int>();
        
        if(root is null) return ret;
        return RecPreorder(root, ret);
    }
     public IList<int> RecPreorder(Node root, IList<int> list) {
        list.Add(root.val);
        for(int i = 0; i < root.children.Count; i++) {
            if(root.children[i] != null) list = RecPreorder(root.children[i], list);
        }
        return list;
    }
}