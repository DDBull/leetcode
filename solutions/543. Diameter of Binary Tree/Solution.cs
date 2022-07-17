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
    public int DiameterOfBinaryTree(TreeNode root) {
        int answer = 0;

	    Dfs(root, 0, ref answer);

	    return answer;
    }

    private int Dfs(TreeNode cur, int depth, ref int answer) 
    {
	    if (cur is null) return 0;  
	    int left = Dfs(cur.left, depth + 1, ref answer);
	    int right = Dfs(cur.right, depth + 1, ref answer);
	    int temp = (left - depth) + (right - depth); 
	    answer = Math.Max(answer, temp);

	    return Math.Max(depth, Math.Max(left, right));
	}
}
