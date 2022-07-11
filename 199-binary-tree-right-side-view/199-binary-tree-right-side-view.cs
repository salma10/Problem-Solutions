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
    public IList<int> RightSideView(TreeNode root) {
                
        if(root == null)
            return new List<int>();
        
        List<int> result = new List<int>();
        Queue<TreeNode> levelOrder = new Queue<TreeNode>();
        levelOrder.Enqueue(root);
        
        while(levelOrder.Count > 0)
        {
            int count = levelOrder.Count;
            
            while(count > 0)
            {
                TreeNode current = levelOrder.Dequeue();
                if(current.left != null)
                   levelOrder.Enqueue(current.left); 
                if(current.right != null)
                   levelOrder.Enqueue(current.right); 
                count--;
                if(count == 0)
                    result.Add(current.val);
            }          
        }
        
        return result;
    }
}