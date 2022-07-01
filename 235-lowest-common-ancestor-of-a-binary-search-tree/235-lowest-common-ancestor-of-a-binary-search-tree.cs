/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null)
            return null;
        int pValue = p.val;
        int qValue = q.val;
        while(root != null)
        {
            if(pValue > root.val && qValue > root.val)
                root = root.right;
            else if(pValue < root.val && qValue < root.val)
                root = root.left;
            else
                return root;
        }
        return null;
    }
}