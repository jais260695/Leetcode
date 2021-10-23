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
    public ListNode ReverseKGroup(ListNode head, int k) {
        int size  = 0;
        ListNode temp = head;
        while(temp!=null)
        {
            temp = temp.next;
            size++;
        }
        
        int n = size/k;
        ListNode prev = null;
        ListNode curr = head;
        ListNode nxt = curr.next;
        temp = curr;
        ListNode p = null;
        for(int i=0;i<n;i++)
        {
            int j=0;
            while(j<k)
            {
                curr.next = prev;
                prev = curr;
                curr = nxt;
                if(curr!=null)
                    nxt = curr.next;
                j++;
            }
            if(i!=0) p.next = prev;
            temp.next = curr;
            if(i==0) head=prev;
            prev = temp;
            p=temp;
            temp=curr;
        }
        return head;
    }
}