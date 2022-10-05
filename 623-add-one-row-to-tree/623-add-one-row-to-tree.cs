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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        if (depth == 1)
        {
            var newRoot = new TreeNode(val);
            newRoot.left = root;
            return newRoot;
        }

        depth--;
        Queue<TreeNode> bfs = new Queue<TreeNode>();
        bfs.Enqueue(root);
        int currDepth = 1;

        while (bfs.Count > 0)
        {
            int count = bfs.Count;

            for (int i = 0; i < count; i++)
            {
                var node = bfs.Dequeue();
                if (currDepth == depth)
                {
                    var newNodeLeft = new TreeNode(val);
                    var newNodeRight = new TreeNode(val);
                    newNodeLeft.left = node.left;
                    newNodeRight.right = node.right;

                    node.left = newNodeLeft;
                    node.right = newNodeRight;
                }
                else
                {
                    if (node.left != null)
                    {
                        bfs.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        bfs.Enqueue(node.right);
                    }
                }
            }

            if (currDepth == depth)
            {
                break;
            }

            currDepth++;

        }

        return root;
    }
}