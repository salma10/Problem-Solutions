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
    public string Tree2str(TreeNode root) {
        if(root == null)
            return "";
        
        StringBuilder sb = new StringBuilder();
        Preorder(root, sb);
        return sb.ToString();
    }
    public void Preorder(TreeNode root, StringBuilder sb)
    {
        if(root == null)
            return;
        
        sb.Append(root.val);
        
        if(root.left != null)
        {
            sb.Append("(");
            Preorder(root.left, sb);
            sb.Append(")");
        }
        
        if(root.right != null)
        {
            if(root.left == null)
                sb.Append("()");
          
            sb.Append("(");
            Preorder(root.right, sb);
            sb.Append(")");    
        }
    }
}