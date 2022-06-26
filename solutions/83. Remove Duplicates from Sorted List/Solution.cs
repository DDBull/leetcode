/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        
        var cur = head;
        
        while (cur is not null)
        {
            while (cur.next is not null && cur.next.val == cur.val)
            {
                cur.next = cur.next.next;
            }
            cur = cur.next;
        }
        
        return head;
    }
}
