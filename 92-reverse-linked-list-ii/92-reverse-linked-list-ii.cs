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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(left == right || head == null)
            return head;
        
        ListNode current = head, prev = null;
        
        while(left > 1)
        {
            prev = current;
            current = current.next;
            left--;
            right--;
        }
        

        ListNode leftNode = current;
        ListNode rightNode = null;
        ListNode nodeBeforeReverse = prev;
        
        while(right > 0)
        {
            rightNode = current.next;
            current.next = prev;
            prev = current;
            current = rightNode;
            right--;
        }
        if(nodeBeforeReverse != null)
            nodeBeforeReverse.next = prev;
        else
            head = prev;
        leftNode.next = current;
        return head;
    }
    
}