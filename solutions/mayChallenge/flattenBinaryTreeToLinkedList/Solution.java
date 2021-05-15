import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Queue;

class Solution {

    private ArrayDeque<TreeNode> q = new ArrayDeque<>();

    public void flatten(TreeNode root) {
        if (root == null) {
            return;
        }

        order(root);

        while (!q.isEmpty()) {
            root.val = q.pop().val;
            root.left = null;
            root.right = q.peekFirst();
            if (root.right != null) {
                root = root.right;
            }
        }
    }

    private void order(TreeNode cur) {
        q.add(cur);

        if (cur.left != null) {
            order(cur.left);
        }

        if (cur.right != null) {
            order(cur.right);
        }
    }
}
