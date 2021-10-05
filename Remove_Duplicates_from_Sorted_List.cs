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
    public ListNode DeleteDuplicates(ListNode head) {
        
        ListNode temp1 = head;
        while(head!=null)
        {
            ListNode temp2 = head.next;
            while(temp2!=null && head.val==temp2.val)
            {
                temp2 = temp2.next;
            }
            head.next = temp2;
            head = temp2;         
        }
        return temp1;
    }
}