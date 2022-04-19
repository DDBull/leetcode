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
    TreeNode firstElement = null;
    TreeNode secondElement = null;
    TreeNode prevElement = new(Int32.MinValue);
    
    public void RecoverTree(TreeNode root) {
        Traverse(root);
        
        (firstElement.val, secondElement.val) = (secondElement.val, firstElement.val);
    }
    
    private void Traverse(TreeNode root)
    {
        if (root is null) return;
        
        Traverse(root.left);
        
        if (firstElement is null && root.val < prevElement.val)
        {
            firstElement = prevElement;
        }
        
        if (firstElement is not null && root.val < prevElement.val)
        {
            secondElement = root;
        }
        
        prevElement = root;
        
        Traverse(root.right);
    }
}
