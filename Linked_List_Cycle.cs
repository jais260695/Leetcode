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
    public bool HasCycle(ListNode head) {
        ListNode t1 = head;
        ListNode t2 = head;
        while(t2!=null && t2.next!=null)
        {
            if( t2.next==t1)
            {
                return true;
            }
            t1 = t1.next;
            t2 = t2.next.next;
            
        }
        return false;
    }
}