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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return DFS(inorder, 0, inorder.Length - 1, preorder, 0, preorder.Length - 1);
    }
        public TreeNode DFS(int[] inOrder, int inLeft, int inRight, int[] preOrder, int preLeft, int preRight) 
    {
        if (preLeft > preRight) {
            return null;
        }

        var curValue = preOrder[preLeft];

        var count = 0;
        var i = inLeft;

        while (i <= inRight) {
            if (inOrder[i] == curValue) {
                break;
            }
            i++;
            count++;
        }

        var cur = new TreeNode(curValue);
        cur.left = DFS(inOrder, inLeft, i - 1, preOrder, preLeft + 1, preLeft + count);
        cur.right = DFS(inOrder, i + 1, inRight, preOrder, preLeft + count + 1, preRight);

        return cur;
    }
}