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
    private int result = 0;
    
    private void DFS(TreeNode root, int x)
    {
        if (root is null) 
        {
            return;
        }
        
        if (root.val >= x)
        {
            result++;
            x = root.val;
        }
        
        DFS(root.left, x);
        DFS(root.right, x);
    }
    
    public int GoodNodes(TreeNode root) {
        DFS(root, -11000);
        
        return result;
    }
}
