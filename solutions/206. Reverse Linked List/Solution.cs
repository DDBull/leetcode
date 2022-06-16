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
    public ListNode ReverseList(ListNode head) {
        Stack<ListNode> st = new();
        
        if (head is null) return head;
        
        while (head is not null)
        {
            st.Push(head);
            head = head.next;
        }
        
        ListNode cur = new();
        var ans = cur;
        
        while (st.Count > 0)
        {
            cur.val = st.Pop().val;
            
            if (st.Count > 0)
            {
                cur.next = new ListNode();
                cur = cur.next;
            }
        }
        
        return ans;
    }
}
