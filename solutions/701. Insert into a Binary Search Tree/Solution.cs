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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
         TreeNode cur = new();
         cur.val = val;
        
         if (root is null)
         {
             return cur;
         }
        
        TreeNode ans = root;
        
        while (true)
        {
            if (root.val > val)
            {
                if (root.left is not null)
                {
                    root = root.left;
                }
                else
                {
                    root.left = cur;
                    break;
                }
            }
            else
            {
                if (root.right is not null)
                {
                    root = root.right;
                }
                else
                {
                    root.right = cur;
                    break;
                }
            }
        }
        
        return ans;
    }
}
