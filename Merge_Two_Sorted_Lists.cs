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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if(l1==null) return l2;
        if(l2==null) return l1;
        ListNode result = new ListNode();
        ListNode temp = result;
        while(l1!=null && l2!=null)
        {
            if(l1.val<=l2.val)
            {
                result.next = l1;
                result = l1;
                l1 = l1.next;
            }
            else
            {
                result.next = l2;
                result = l2;
                l2 = l2.next;
            }
        }
        
        if(l1!=null)
        {
            result.next = l1;
        }
        
        if(l2!=null)
        {
            result.next = l2;
        }
        return temp.next;
    }
}