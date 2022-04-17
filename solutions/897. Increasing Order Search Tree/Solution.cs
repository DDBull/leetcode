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
public class Solution 
{
    List<int> ans = new();
    
    private void SearchNode(TreeNode cur)
    {
        if (cur.left is not null) SearchNode(cur.left);
        ans.Add(cur.val);
        if (cur.right is not null) SearchNode(cur.right);
    }
    
    public TreeNode IncreasingBST(TreeNode root) 
    {
        SearchNode(root);

        TreeNode tree = new();
        TreeNode first = tree;

        int i;
        
        for (i = 0; i + 1 < ans.Count; i++)
        {
          tree.val = ans[i];
          tree.right = new();
          tree = tree.right;
        }

        tree.val = ans[i];

        return first;
    }
}
