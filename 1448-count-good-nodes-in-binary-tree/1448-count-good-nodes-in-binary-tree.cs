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
    int count = 0;
    public int GoodNodes(TreeNode root) {
        int max = Int32.MinValue;
        CountGoodNodes(root, max);
        return count;
    }
    
    private void CountGoodNodes(TreeNode root, int currentMax)
    {
        if(root == null)
            return;
        if(currentMax <= root.val)
        {
            count++;
        }
           
        CountGoodNodes(root.left, Math.Max(currentMax, root.val));
        CountGoodNodes(root.right, Math.Max(currentMax, root.val));
    }
}