/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        
        ListNode currHeadA = headA;
        ListNode currheadB = headB;
        
        while(currHeadA != null && currheadB != null)
        {
            currHeadA = currHeadA.next;
            currheadB = currheadB.next;
        }
        
        if(currHeadA == null)
        {
            while(currheadB != null)
            {
               headB = headB.next;
               currheadB = currheadB.next; 
            }
        }
        else
        {
            while(currHeadA != null)
            {
               headA = headA.next;
               currHeadA = currHeadA.next; 
            }
        }
        
        
        while(headA != headB)
        {
            headA = headA.next;
            headB = headB.next;
        }
        
        return headA;
    }
}