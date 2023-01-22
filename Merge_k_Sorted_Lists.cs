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
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode,int> queue = new PriorityQueue<ListNode,int>();

        foreach(var list in lists)
        {
            if(list!=null)
                queue.Enqueue(list,list.val);
        }
        ListNode result = new ListNode();
        ListNode ref1 = result;
        while(queue.Count>0)
        {
            ListNode node = queue.Dequeue();
            if(node.next!=null)
                queue.Enqueue(node.next,node.next.val);
        
            result.next = node;
            node.next = null;
            result = result.next;
            
        }
        return ref1.next;
    }
}