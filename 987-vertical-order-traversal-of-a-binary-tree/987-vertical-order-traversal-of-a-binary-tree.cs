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
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        IList<IList<int[]>> negativeList = new List<IList<int[]>>(), positiveList = new List<IList<int[]>>();

      Helper(root, 0, 0, negativeList, positiveList);

      IList<IList<int>> res = new List<IList<int>>();

      for (int i = negativeList.Count - 1; i >= 0; i--)
      {
        res.Add(new List<int>());

        foreach (var arr in negativeList[i])
          res[res.Count - 1].Add(arr[1]);
      }

      for (int i = 0; i < positiveList.Count; i++)
      {
        res.Add(new List<int>());

        foreach (var arr in positiveList[i])
          res[res.Count - 1].Add(arr[1]);
      }

      return res;
    }
    
    public void Helper(TreeNode node, int index, int deep, IList<IList<int[]>> negativeList, IList<IList<int[]>> positiveList)
    {
          if (node == null)
            return;

          IList<IList<int[]>> list;

          var abs = Math.Abs(index);

          if (index >= 0)
            list = positiveList;
          else
          {
            list = negativeList;
            abs--;
          }

          if (abs == list.Count)
            list.Add(new List<int[]>());

          int i = list[abs].Count - 1;
          for (; i >= 0; i--)
            if (list[abs][i][0] > deep || (list[abs][i][0] == deep && list[abs][i][1] < node.val)) break;

          list[abs].Insert(i + 1, new[] {deep, node.val});

          Helper(node.left, index - 1, deep - 1, negativeList, positiveList);
          Helper(node.right, index + 1, deep - 1, negativeList, positiveList);
    }
}