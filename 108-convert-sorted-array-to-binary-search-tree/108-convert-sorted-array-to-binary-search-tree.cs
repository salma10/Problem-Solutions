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
    public TreeNode SortedArrayToBST(int[] nums) {
        return ConstructTree(nums, 0, nums.Length - 1);
    }
    
    private TreeNode ConstructTree(int[] nums, int left, int right)
    {
        if (right < left) return null;
        int mid = (left + right)/2;
        TreeNode node = new TreeNode(nums[mid]);
        node.left = ConstructTree(nums, left, mid - 1);
        node.right = ConstructTree(nums, mid + 1, right);
    
        return node;
    }
}