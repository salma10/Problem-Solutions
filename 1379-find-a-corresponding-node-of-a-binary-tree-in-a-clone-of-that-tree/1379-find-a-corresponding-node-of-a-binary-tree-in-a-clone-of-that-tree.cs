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
    TreeNode targetLocal, result;

    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        targetLocal = target;
        Inorder(original, cloned);
        return result;
    }
    
    public void Inorder(TreeNode original, TreeNode cloned) 
    {
        if (original != null) 
        {
            Inorder(original.left, cloned.left);
            
            if (original == targetLocal) 
            {
                result = cloned;    
            }
            
            Inorder(original.right, cloned.right);    
        }
    }
}