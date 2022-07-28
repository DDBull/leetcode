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
    public ListNode MergeKLists(ListNode[] lists) 
    {    
        if (lists is null || lists.Length == 0) return null;
        
        int interval = 1;
        
        while (interval < lists.Length)
        {
            for (int i = 0; i < lists.Length; i = i + interval * 2)
            {
                if (i + interval < lists.Length) 
                {
                    lists[i] = MergeTwoLists(lists[i], lists[i + interval]);
                }
            }
            
            interval *= 2;
        }
        
        return lists[0];
    }
    
    private ListNode MergeTwoLists(ListNode first, ListNode second)
    {
        ListNode dummy = new();
        ListNode cur = dummy;
        
        while (first != null && second != null)
        {
            if (first.val < second.val)
            {
                cur.next = first;
                first = first.next;
            }
            else
            {
                cur.next = second;
                second = second.next;
            }
            cur = cur.next;
        }
        
        if (first != null) cur.next = first;
        if (second != null) cur.next = second;
        
        return dummy.next;
    }
}
