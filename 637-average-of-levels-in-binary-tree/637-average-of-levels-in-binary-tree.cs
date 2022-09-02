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
    public IList<double> AverageOfLevels(TreeNode root) {
        
        IList<double> result = new List<double>();
        if(root == null)
            return result;
        
        Queue<TreeNode> stack = new Queue<TreeNode>();
        stack.Enqueue(root);
        
        while(stack.Count > 0)
        {
            int count = stack.Count;
            double levelTotal = 0;
            double levelNode = stack.Count;
            
            while(count > 0)
            {
                TreeNode current = stack.Dequeue();
                
                if(current.left != null)
                    stack.Enqueue(current.left);
                if(current.right != null)
                    stack.Enqueue(current.right);
                
                levelTotal += current.val;
                count--;
            }
           
              result.Add(levelTotal / levelNode);
        }
        
        return result;     
    }
}