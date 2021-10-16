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
    public int GetDecimalValue(ListNode head) {
        int res = 0;
        while(head.next!=null)
        { 
            res = res|head.val;
            res<<=1;
            head = head.next;
        }
        res = res|head.val;
        return res;
    }
}