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
    public ListNode MiddleNode(ListNode head) {
        ListNode lnode = new ListNode();
        lnode = head;
        while(lnode != null && lnode.next!=null)
        {
            head = head.next;
            lnode = lnode.next.next;
        }
        return head;
    }
}