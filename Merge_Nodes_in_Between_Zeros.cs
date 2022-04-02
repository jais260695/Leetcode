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
    public ListNode MergeNodes(ListNode head) {
        ListNode head1 = new ListNode();
        ListNode temp = head1;
        int sum = 0;
        while(head!=null)
        {
            if(head.val==0)
            {
                if(sum>0)
                {
                    temp.next = new ListNode(sum);
                    temp = temp.next;
                    sum=0;
                }
            }
            else if(head.val!=0)
            {
                sum+=head.val;
            }
            head = head.next;
        }
        return head1.next;
    }
}