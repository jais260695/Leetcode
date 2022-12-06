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
    public ListNode OddEvenList(ListNode head) {
        if(head==null || head.next==null || head.next.next==null) return head;

        ListNode  even = head;
        ListNode  odd = head.next;
        ListNode  oddTemp = head.next;
        while(odd!=null)
        {
            even.next = odd.next;
            if(even.next!=null)
            { 
                even = even.next;
            }
            odd.next = even.next;
            odd=odd.next;
        }
        even.next = oddTemp;
        return head;
    }
}