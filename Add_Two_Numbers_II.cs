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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode prev = null;
        ListNode curr = l1;
        ListNode next = null;
        
        while(curr!=null)
        {
            
        
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        
        l1 = prev;
        
        
        prev = null;
        curr = l2;
        next = null;
        
        while(curr!=null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        
        l2 = prev;
        
        int c = 0;
        
        ListNode result = new ListNode(c);
        
        ListNode temp = result;
        while(l1!=null && l2!=null)
        {
            int val = l1.val + l2.val + c;
            temp.next = new ListNode(val%10);
            temp = temp.next;
            c = val/10;
            
            l1 = l1.next;
            l2 = l2.next;
        }
        
        while(l1!=null)
        {
            int val = l1.val + c;
            temp.next = new ListNode(val%10);
            temp = temp.next;
            c = val/10;
            
            l1 = l1.next;
        }
        
        while(l2!=null)
        {
            int val = l2.val + c;
            temp.next = new ListNode(val%10);
            temp = temp.next;
            c = val/10;
            
            l2 = l2.next;
        }
        
        if(c!=0)
        {
            temp.next = new ListNode(c);
            temp = temp.next;
        }
        
        prev = null;
        curr = result.next;
        next = null;
        
        while(curr!=null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        
        result = prev;
        
        return result;
    }
}