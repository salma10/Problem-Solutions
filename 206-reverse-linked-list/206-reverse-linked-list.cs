/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode newHeadNode = null; 
        while(head != null)
        {
            ListNode nextNode = head.next;
            head.next = newHeadNode;
            newHeadNode = head;
            head = nextNode;
        }
        return newHeadNode; 
    }
}