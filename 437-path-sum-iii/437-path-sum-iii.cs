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
    public int PathSum(TreeNode root, int sum) {
            if (root == null)
                return 0;
            var map = new Dictionary<long, long>();
            long totalPaths = 0; 
            preorderTraversal(root, (long)sum, map, 0, ref totalPaths);

            return (int)totalPaths;
    }
    
    public void preorderTraversal(TreeNode root, long sum, Dictionary<long, long> map, long prefixSum, ref long totalPaths)
        {
            if (root == null)
                return;

            var current = root.val;
            var newPrefixSum = prefixSum + current;
            var search = newPrefixSum - sum;
            if (map.ContainsKey(search))
            {
                totalPaths += map[search];
            }
            
            if(search == 0)
                totalPaths += 1; 
           
            if (!map.ContainsKey(newPrefixSum))
            {
                map.Add(newPrefixSum, 0);
            }

            map[newPrefixSum]++;

            preorderTraversal(root.left,  sum, new Dictionary<long, long>(map),  newPrefixSum, ref totalPaths);
            preorderTraversal(root.right, sum, new Dictionary<long, long>(map),  newPrefixSum, ref totalPaths);
        }
}