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
    public TreeNode SortedArrayToBST(int[] nums) {
        return BuildTree(nums, 0, nums.Length - 1);
    }
    
    private TreeNode BuildTree(int[] nums, int left, int right)
    {
        if (left > right) return null;
        
        TreeNode cur = new();
        
        int middle = (right + left) / 2;
        cur.val = nums[middle];
        
        cur.left = BuildTree(nums, left, middle - 1);
        cur.right = BuildTree(nums, middle + 1, right);
        
        return cur;
    }
}
