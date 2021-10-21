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
        
        ListNode result = l1;
        ListNode f = l1;
        int sum = 0;
        int carry =0;
        
        while(l1!=null && l2!=null)
        {
            int tot = l1.val+l2.val+carry;
            carry = tot/10;
            sum = tot%10;
            l1.val = sum;
            f=l1;
            l1=l1.next;
            l2=l2.next;
        }
        
        while(l1!=null)
        {
            int tot = l1.val+carry;
            carry = tot/10;
            sum = tot%10;
            l1.val = sum;
            f=l1;
            l1=l1.next;
        }
        
         while(l2!=null)
        {
            int tot = l2.val+carry;
            carry = tot/10;
            sum = tot%10;
            ListNode temp = new ListNode(sum);
            f.next = temp;
            f=f.next;
            l2=l2.next;
        }
        
        if(carry!=0)
        {
             ListNode temp = new ListNode(carry);
            f.next = temp;
        }
        
        return result;
        
    }
}