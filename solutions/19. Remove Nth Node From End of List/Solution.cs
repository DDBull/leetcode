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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        ListNode node = head;
        int cur = 0;
        
        int total = 1;
        
        while (node.next is not null)
        {
            total++;
            node = node.next;
        }
        
        n = total - n + 1;
        
        if (n == 1)
        {
            return head.next;
        }
        
        node = head;
        
        while (node is not null)
        {
            cur++;
            if (cur + 1 == n)
            {
                ListNode target = node.next;
                node.next = target.next;
                return head;
            }
            node = node.next;
        }
        
        return head;
    }
}
