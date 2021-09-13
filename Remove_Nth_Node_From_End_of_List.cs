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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode current = head;
        ListNode p = head;
        for(int i=0;i<n;i++)
        {
            p = p.next;
        }
        if(p==null)
        {
            return head.next;
        }
        while(p.next!=null)
        {
            current = current.next;
            p = p.next;
        }
        current.next = current.next.next;
        return head;
    }
}