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
    public bool HasPathSum(TreeNode root, int targetSum) {
        return Dfs(root, targetSum, 0);
    }
    
    private bool Dfs(TreeNode root, int targetSum, int sum)
    {
        if (root is null) return false;
        if (root.left is null && root.right is null && sum + root.val == targetSum) return true;
        return Dfs(root.left, targetSum, sum + root.val) || Dfs(root.right, targetSum, sum + root.val);
    }
}
