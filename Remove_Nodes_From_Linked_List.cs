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
    public ListNode RemoveNodes(ListNode head) {
        Stack<ListNode> st = new Stack<ListNode>();
        
        while(head!=null)
        {
            if(st.Count()==0)
            { 
                st.Push(head);
            }
            else{
                while(st.Count()>0 && st.Peek().val < head.val)
                {
                    st.Pop();
                }
                
                if(st.Count()>0)
                {
                    st.Peek().next = head;
                }
                st.Push(head);
            }
            
            head = head.next;
        }
        
        while(st.Count()>1)
        {
            st.Pop();
        }
        
        return st.Peek();
    }
}