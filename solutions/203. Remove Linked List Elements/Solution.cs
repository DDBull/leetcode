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
    public ListNode RemoveElements(ListNode head, int val) {
        if (head is null) return head;
        
        while (head is not null && head.val == val) 
        {
            head = head.next;
        }
        
        var cur = head;
        
        while (cur is not null)
        {
            while (cur.next is not null && cur.next.val == val)
            {
                cur.next = cur.next.next;
            }
            cur = cur.next;
        }
        
        return head;
    }
}
