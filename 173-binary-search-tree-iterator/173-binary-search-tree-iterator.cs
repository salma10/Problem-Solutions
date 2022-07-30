/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class BSTIterator {
    List<int> data;
    int index;
    int maxLen;
    public BSTIterator(TreeNode root) {
        data = InorderTraversal(root);
        index = -1;
        maxLen = data.Count;
    }    
    public int Next() {
       index++;
       return data[index];
    }
    public bool HasNext() {
        if(index < maxLen - 1)
            return true;
        else
            return false;
    }
    
    public List<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        if(root == null)
            return result;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while(stack.Count > 0)
        {
            TreeNode currNode = stack.Pop();
            
            if(currNode.right == null && currNode.left == null)
            {
                result.Add(currNode.val);
                continue;
            }
                          
            if(currNode.right != null)
                stack.Push(currNode.right);
            
            TreeNode currNodeLeft = currNode.left;
            currNode.right = null;
            currNode.left = null;
            stack.Push(currNode);
            
            if(currNodeLeft != null)
                stack.Push(currNodeLeft);
        }
        return result;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */