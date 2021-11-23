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
    public ListNode SwapNodes(ListNode head, int k) {
        int n = 1;
        ListNode temp1 = null;
        ListNode temp2 = head;
        ListNode temp = head;
        while(n<k)
        {
            temp = temp.next;
            n++;
        }
        temp1 = temp;
        while(temp.next!=null)
        {
            temp = temp.next;
            temp2 = temp2.next;
        }
        int val = temp1.val;
        temp1.val = temp2.val;
        temp2.val = val;
        
        return head;
    }
}