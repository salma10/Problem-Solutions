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
    HashSet<TreeNode> covered;
    int noOfCamera;
    public int MinCameraCover(TreeNode root) {
        covered = new HashSet<TreeNode>();
        noOfCamera = 0;
        covered.Add(null);
        GetMinCameraSum(root, null);
        return noOfCamera;
    }
    private void GetMinCameraSum(TreeNode currentNode, TreeNode parentNode)
    {
        if(currentNode != null)
        {
            GetMinCameraSum(currentNode.left, currentNode);
            GetMinCameraSum(currentNode.right, currentNode);
            if(parentNode == null && !covered.Contains(currentNode) || !covered.Contains(currentNode.left) || !covered.Contains(currentNode.right))
            {
                noOfCamera++;
                covered.Add(parentNode);
                covered.Add(currentNode);
                covered.Add(currentNode.left);
                covered.Add(currentNode.right);
            }
        }
    }
}