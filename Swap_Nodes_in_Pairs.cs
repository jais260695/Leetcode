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
    public ListNode SwapPairs(ListNode head) {
        ListNode temp = head;
        while(temp!=null && temp.next!=null)
        {
            int t= temp.val;
            temp.val = temp.next.val;
            temp.next.val = t;
            temp = temp.next.next;
        }
        return head;
    }
}