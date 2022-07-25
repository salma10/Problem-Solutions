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
    public ListNode SortList(ListNode head) {
        if(head == null || head.next == null)
            return head;
        ListNode midNode = GetMid(head);
        ListNode first = SortList(head);
        ListNode second = SortList(midNode);
        return Merge(first, second);
    }   
    private ListNode GetMid(ListNode head)
    {
        if(head == null)
            return head;
        ListNode first = head;
        ListNode second = head;
        ListNode slowPrev = null;
        while(second != null && second.next != null)
        {
            slowPrev = first;
            first = first.next;
            second = second.next.next;
        }
        slowPrev.next = null;
        return first;
    }
    private ListNode Merge(ListNode first, ListNode second)
    {
        if(first == null)
            return second;
        else if(second == null)
            return first;
        
        ListNode result = new ListNode();
        ListNode temp = result;
        
        while(first != null && second != null)
        {
            if(first.val <= second.val)
            {
                temp.next = first;
                temp = temp.next;
                first = first.next;
            }
            else
            {
                temp.next = second;
                temp = temp.next;
                second = second.next;
            }
        }
        temp.next = first == null ? second : first;
        return result.next;
    }
}