/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    private TreeNode ans = null;
    
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        DFS(root, p, q);
        
        return ans;
    }
    
    private (bool pIsFound, bool qIsFound) DFS(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root is null) 
        {
            return (false, false);
        }
        
        if (ans != null)
        {
            return (true, true);
        }
        
        bool pIsFound = (root == p) || DFS(root.left, p, q).pIsFound || DFS(root.right, p, q).pIsFound;
        bool qIsFound = (root == q) || DFS(root.left, p, q).qIsFound || DFS(root.right, p, q).qIsFound;
        
        if (ans is null && pIsFound && qIsFound) 
        {
            ans = root;
        }
        
        return (pIsFound, qIsFound);
    }
}
