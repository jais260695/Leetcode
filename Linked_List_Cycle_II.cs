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
        ListNode p1 = head;
        ListNode p2 = head;
        ListNode p3 = head;
        while(p2!=null && p2.next!=null)
        {
            p1 = p1.next;
            p2 = p2.next.next;
            if(p1==p2)
            {
                while(p3!=p1)
                {
                    p3 = p3.next;
                    p1 = p1.next;
                }
                return p1;
            }
        }
        return null;
    }
}