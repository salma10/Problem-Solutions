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
    public int DeepestLeavesSum(TreeNode root) {
          var currentLevelNodes = new List<TreeNode>(new [] {root});
        var levelSum = 0;
        
        while(currentLevelNodes.Count > 0) {
            levelSum = GetLevelSum(currentLevelNodes);
            
            currentLevelNodes = GetNextLevelNodes(currentLevelNodes);
        } 
        
        return levelSum;
    }
     private List<TreeNode> GetNextLevelNodes(List<TreeNode> nodes) {
        List<TreeNode> result = new List<TreeNode>();
        
        foreach(var node in nodes) {
            if (node.left != null) {
                result.Add(node.left);
            }
            
            if (node.right != null) {
                result.Add(node.right);
            }
        }
        
        return result;
    }
    
    private int GetLevelSum(List<TreeNode> nodes) {
        int result = 0;
        
        foreach(var node in nodes) {
            result += node.val;
        }
        
        return result;
    }
}