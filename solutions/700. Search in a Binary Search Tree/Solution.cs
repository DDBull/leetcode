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
    public TreeNode SearchBST(TreeNode root, int val) {
        if (root is null) return null;
        if (root.val == val) return root;
        TreeNode left = SearchBST(root.left, val);
        if (left is not null) return left;
        return SearchBST(root.right, val);
    }

    public TreeNode SearchBST(TreeNode root, int val) {
        if(root == null || root.val == val)
        {
             return root;
        }
        
        if(root.val > val)
        {
            return SearchBST(root.left, val);
        }
        else
        {
            return SearchBST(root.right, val);
        }
    }
}
