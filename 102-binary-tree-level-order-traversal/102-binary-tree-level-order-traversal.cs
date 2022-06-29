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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        IList<IList<int>> result = new List<IList<int>>();
        if(root ==  null)
            return result;
        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            List<int> levelReseult = new List<int>();
            int count = queue.Count;
            while(count > 0)
            {
                TreeNode currNode = queue.Dequeue();
                levelReseult.Add(currNode.val);
                if(currNode.left != null)
                    queue.Enqueue(currNode.left);
                if(currNode.right != null)
                    queue.Enqueue(currNode.right);
                count--;
            }
            result.Add(levelReseult);
        }
        return result;
    }
}