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
    public int Rob(TreeNode root) {
        int[] maxAmount = GetMaxSum(root);
        return Math.Max(maxAmount[0], maxAmount[1]);
    }
    private int[] GetMaxSum(TreeNode root)
    {
        if(root== null)
            return new int[2];
        
        int[] left = GetMaxSum(root.left);
        int[] right = GetMaxSum(root.right);
        
        int[] maxAmount = new int[2];
        maxAmount[0] = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);
        maxAmount[1] = root.val + left[0] + right[0];
        return maxAmount;
    }
}