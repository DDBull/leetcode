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
    public ListNode MiddleNode(ListNode head) {
        int total = 1;
        
        ListNode node = head;
        
        while (node.next is not null)
        {
            node = node.next;
            total++;  
        } 
        
        int mid = total / 2 + 1;
        int cur = 1;
        node = head;
        
        do 
        {
            if (cur == mid) 
            {
                return node;
            }
            node = node.next;
            cur++;
        } while (node is not null);
        
        return head;
    }
}
