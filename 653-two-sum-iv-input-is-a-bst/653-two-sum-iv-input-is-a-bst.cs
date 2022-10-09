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
public class Solution {
    public bool FindTarget(TreeNode root, int k) {
        if(root == null || (root.left == null && root.right == null))
            return false;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Count > 0)
        {
            TreeNode currNode = stack.Pop();
            TreeNode isFound = new TreeNode();
            if(k - currNode.val > currNode.val)
                isFound = SearchBST(root, k - currNode.val);
            else
                isFound = SearchBST(root, k - currNode.val);
            if(isFound != null && isFound.val != currNode.val)
                return true;
            else
            {
                if(currNode.left != null)
                    stack.Push(currNode.left);
                if(currNode.right != null)
                    stack.Push(currNode.right);
            }
        }
        return false;
    }
    
    public TreeNode SearchBST(TreeNode root, int val) {
        if(root == null || root.val == val)
            return root;
        else if(root.val < val)
            return SearchBST(root.right, val);
        else
            return SearchBST(root.left, val);
    }
}