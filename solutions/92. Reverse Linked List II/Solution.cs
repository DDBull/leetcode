// DSM. U
public class Solution 
{
    public ListNode ReverseBetween(ListNode head, int l, int r) 
    {
        if (head is null) return null;
        
        ListNode cur = head, prev = null;
        
        while (l > 1)
        {
            prev = cur;
            cur = cur.next;
            l--;
            r--;
        }
        
        ListNode con = prev, tail = cur, third = null;
        
        while (r > 0)
        {
            third = cur.next;
            cur.next = prev;
            prev = cur;
            cur = third;
            r--;
        }
        
        if (con != null) con.next = prev; else head = prev;
        
        tail.next = cur;
        
        return head;
    }
}
