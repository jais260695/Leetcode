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
    public void ReorderList(ListNode head) {
        Dictionary<ListNode,ListNode> parent = new Dictionary<ListNode,ListNode>();                
        ListNode tail = head;
        while(tail.next!=null)
        {
            parent.Add(tail.next,tail);
            tail = tail.next;
        }

        ListNode temp = head;
        ListNode curr = head;
        while(curr.next!=tail && curr!=tail)
        {
            temp = curr;
            curr = temp.next;
            temp.next = tail;
            ListNode prev = parent[tail];
            prev.next = tail.next;
            tail.next = curr;
            tail = prev;
            ListNode t  =head;
        }
    }
}