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
    int ans;
    public int MaxDepth(TreeNode root) {
        ans = 0;
        Dfs(root, 1);
        
        return ans;
    }
    
    private void Dfs(TreeNode cur, int depth)
    {
        if (cur is null) return;
        
        ans = Math.Max(ans, depth);
        
        Dfs(cur.left, depth + 1);
        Dfs(cur.right, depth + 1);
    }
}
