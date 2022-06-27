/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if(head == null)
        {
		    return null;
	    }

        HashSet<ListNode> hash = new HashSet<ListNode>();

        bool isCycle = false;
        while(!isCycle)
        {
            if(head.next != null)
            {
                if(!hash.Contains(head))
                    hash.Add(head);
                else
                    return head;

                head = head.next;
            }
            else
            {                   
                return null;
            }      
        }

        return null;
    }
}