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
    int result;
    public int MaxPathSum(TreeNode root) {
        result = Int32.MinValue;
        
        DFS(root);
        
        return result;
    }
    
    private int DFS(TreeNode cur)
    {
        if (cur is null)
        {
            return Int32.MinValue;
        }
        
        int leftChild = DFS(cur.left);
        int rightChild = DFS(cur.right);
        int curPath = cur.val;
        
        if (leftChild > 0)
        {
            curPath += leftChild;
        }
        if (rightChild > 0)
        {
            curPath += rightChild;
        }
        result = Math.Max(result, curPath);
        
        if (leftChild > 0 && rightChild > 0)
        {
            curPath -= Math.Min(leftChild, rightChild);
        }
        
        return curPath;
    }
}
