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
        if(head == null) return null;
        
        if(head.next != null && head.next.val == head.val)
        {
            while(head.next != null && head.val == head.next.val) 
            {
                head = head.next;
            }
            return DeleteDuplicates(head.next);
        }
        else{
            head.next = DeleteDuplicates(head.next);
        }
        return head;
    }
}
