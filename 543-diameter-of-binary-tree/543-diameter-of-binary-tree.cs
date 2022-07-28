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
    private int diameterLen = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        DiameterOfNode(root);
        return diameterLen;
        
    }
    
    public int DiameterOfNode(TreeNode root) {
        
        if(root == null)
            return 0;
    
        int maxLeft = DiameterOfNode(root.left);
        int maxRight = DiameterOfNode(root.right);
        
        diameterLen = Math.Max(diameterLen, maxLeft + maxRight);
        
        return Math.Max(maxLeft, maxRight) + 1;
    }
    
    
}