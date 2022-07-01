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
    public bool IsValidBST(TreeNode root) {
        if(root == null)
            return true;
        return isValidSubTree(root, int.MaxValue, int.MinValue);
    }
    
    public bool isValidSubTree(TreeNode root, int max, int min)
    {
        if(root == null)
            return true;
        else if(root.val < min || root.val > max)
            return false;
        else if(root.left == null && root.right == null)
            return true;      
        
        if(root.left != null && (root.left.val >= root.val || root.left.val > max))
            return false;
        if(root.right != null && (root.right.val <= root.val || root.right.val < min))
            return false;
        return  isValidSubTree(root.left, root.val-1, min) && isValidSubTree(root.right, max, root.val+1);
    }
}