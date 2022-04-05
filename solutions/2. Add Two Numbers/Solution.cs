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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode l3 = new();
        ListNode ans = l3; 
        
        while (l1 is not null || l2 is not null) 
        {
            if (l1 is not null) 
            {
                l3.val += l1.val;
            }
            if (l2 is not null)
            {
                l3.val += l2.val;
            }
            
            int rem = l3.val / 10;
            l3.val = l3.val % 10;
            
            if (l1 is not null) l1 = l1.next;
            if (l2 is not null) l2 = l2.next;
            
            if (rem == 1 || l1 is not null || l2 is not null)
            {
                l3.next = new();    
                l3 = l3.next;
                l3.val = rem;
            }
        }
        
        return ans;
    }
}
