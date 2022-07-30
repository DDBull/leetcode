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
    
    public int RangeSumBST(TreeNode root, int low, int high) {
        if (root is null) return 0;
        int cur = 0;
        
        if (root.val >= low && root.val <= high)
        {
            cur += root.val;
        }
        
        if (root.val > low)
        {
            cur += RangeSumBST(root.left, low, high);
        }
        if (root.val < high)
        {
            cur += RangeSumBST(root.right, low, high);
        }
        
        return cur;
    }
}
