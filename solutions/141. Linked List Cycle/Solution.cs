/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    private const int mil = 1000000;
    private const int lim = 100000;
    public bool HasCycle(ListNode head) {
        if (head is null) return false;
        if (head.val > lim) return true;
        
        head.val += mil;
        
        return HasCycle(head.next);
    }
}
