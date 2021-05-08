/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
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

    private static int[] a = new int[20001];

    public TreeNode sortedListToBST(ListNode head) {

        int len = 0;

        while (head != null) {
            a[len++] = head.val;
            head = head.next;
        }

        TreeNode root = new TreeNode();

        if (len > 0) {
            root = balandedBST(0, len - 1);
        } else {
            return null;
        }

        return root;
    }

    private TreeNode balandedBST(int left, int right) {
        TreeNode current = new TreeNode();

        int middle = (left + right) / 2;
        current.val = a[middle];

        if (left <= middle - 1) {
            current.left = balandedBST(left, middle - 1);
        }

        if (middle + 1 <= right) {
            current.right = balandedBST(middle + 1, right);
        }

        return current;
    }
}
