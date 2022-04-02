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
    public int PairSum(ListNode head) {
        ListNode temp = head;
        ListNode temp2 = head;
        while(temp2!=null && temp2.next!=null)
        {
            temp = temp.next;
            temp2 = temp2.next.next;
        }
        
        ListNode t = temp;
        ListNode c = null;
        ListNode n = null;
        while(temp!=null)
        {
            n = temp.next;
            temp.next = c;
            c = temp;
            temp = n;
        }
        
        t = head;
        int result = 0;
        while(c!=null)
        {
            result = Math.Max(result,t.val+c.val);
            t = t.next;
            c = c.next;
        }
        return result;
    }
}