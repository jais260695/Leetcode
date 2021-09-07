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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
        ListNode prev = null;
        ListNode curr = list1;
        int count = 0;
        while(curr!=null && count!=a)
        {
            prev = curr;
            curr = curr.next;
            count++;
        }
        ListNode p = null;
        while(curr!=null && count!=b)
        {
            p=curr;
            curr = curr.next;
            count++;
        }
        p = curr;
        curr=curr.next;
        p.next = null;
        prev.next = list2;
        while(prev.next!=null)
        {
            prev = prev.next;
        }
        prev.next = curr;
        return list1;
    }
}