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
    ListNode left;
    public bool IsPalindrome(ListNode head) {
        left = head;
        return CheckPalindrome(head);
    }
    
    public bool CheckPalindrome(ListNode right)
    {
        if(right == null)
            return true;
        
        bool isSubListPalindrome = CheckPalindrome(right.next);
        
        if (isSubListPalindrome == false)
            return false;
        
        bool result = right.val == left.val;
        left = left.next;
       
        return result;
    }
}