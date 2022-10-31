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
    public ListNode DeleteMiddle(ListNode head) {
        if(head.next==null) return null;
        ListNode prev = null;
        ListNode ptr1 = head;
        ListNode ptr2 = head;
        
        while(ptr2!=null && ptr2.next!=null)
        {
            prev = ptr1;
            ptr1 = ptr1.next;
            ptr2 = ptr2.next.next;
        }
        
        
        prev.next = ptr1.next;
        
        return head;
    }
}