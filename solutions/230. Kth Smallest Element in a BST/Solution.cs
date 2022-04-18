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
    List<int> a = new();
    
    private void SearchNode(TreeNode cur)
    {
        if (cur.left is not null) SearchNode(cur.left);
        a.Add(cur.val);
        if (cur.right is not null) SearchNode(cur.right);
    }
    
    public int KthSmallest(TreeNode root, int k) {
        SearchNode(root);
        return a[k - 1];
    }
}
