/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    HashSet<ListNode> a = new();
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        a.Add(headA);
        
        while (headA.next is not null)
        {
            headA = headA.next;
            a.Add(headA);
        }
        
        if (a.Contains(headB))
        {
            return headB;
        }
        
        while (headB.next is not null)
        {
            headB = headB.next;
            if (a.Contains(headB))
            {
                return headB;
            }
        }
        
        return null;
    }
}
