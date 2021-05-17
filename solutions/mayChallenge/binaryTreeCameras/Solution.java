/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {

    private static final int NOT_MONITORED = 0;
    private static final int MONITORED_NOCAM = 1;
    private static final int MONITORED_CAM = 2;
    private int cameras = 0;


    public int minCameraCover(TreeNode root) {
        return dfs(root) == NOT_MONITORED ? cameras + 1 : cameras;
    }

    private int dfs(TreeNode cur) {
        if (cur == null) {
            return MONITORED_NOCAM;
        }
        int left = dfs(cur.left);
        int right = dfs(cur.right);

        if (left == MONITORED_NOCAM && right == MONITORED_NOCAM) {
            return NOT_MONITORED;
        }
        if (left == NOT_MONITORED || right == NOT_MONITORED) {
            cameras++;
            return MONITORED_CAM;
        }

        return MONITORED_NOCAM;
    }
}
