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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode prev = null;
        while(head!=null && head.val==val)
        {
            head = head.next;
        }
        ListNode temp = head;
        while(temp!=null)
        {
            if(temp.val==val)
            {
                prev.next = temp.next;
                ListNode deleteNode = temp;
                temp = temp.next;
                deleteNode.next = null;
            }
            else
            {
                prev = temp;
                temp = temp.next;
            }            
        }
        return head;
    }
}