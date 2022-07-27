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
    public bool IsBalanced(TreeNode root) {
        if(root == null || (root.left == null && root.right == null))
            return true;
        int left = 0;
        int right = 0;
        return GetTreeHeight(root.left, out left) && GetTreeHeight(root.right, out right) && Math.Abs(left - right) < 2;
    }
    
    private bool GetTreeHeight(TreeNode root, out int height)
    {
        if(root == null)
        {
            height = 0;
            return true;
        }
        
        int leftHeight = 0;
        int rightHeight = 0;
        
        bool leftIsBalanced = GetTreeHeight(root.left, out leftHeight);
        bool rightIsBalanced = GetTreeHeight(root.right, out rightHeight);
        height = Math.Max(leftHeight, rightHeight) + 1;
        
        return leftIsBalanced && rightIsBalanced && Math.Abs(leftHeight - rightHeight) < 2;
    }
}