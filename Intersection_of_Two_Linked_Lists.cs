/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int n1=0,n2=0;
        ListNode temp = headA;
        ListNode temp1 = headB;
        while(temp!=null && temp1!=null)
        {
            n1++;
            n2++;
            temp=temp.next;
            temp1=temp1.next;
        }
        
        
        
        while(temp!=null)
        {
            n1++;
            temp = temp.next;
        }
        
        while(temp1!=null)
        {
            n2++;
            temp1 = temp1.next;
        }
        
        int diff=0;
        if(n1>n2)
        {
            
            diff = n1-n2;
            temp = headA;
            for(int i=0;i<diff;i++)
            {
                temp = temp.next;
            }
            
            temp1 = headB;
            while(temp!=temp1)
            {
                temp=temp.next;
                temp1=temp1.next;
            }
            return temp;
        }
        diff = n2-n1;
        temp = headB;
        for(int i=0;i<diff;i++)
        {
            temp = temp.next;
        }
        temp1 = headA;
        while(temp!=temp1)
        {
            temp=temp.next;
            temp1=temp1.next;
        }
        return temp;
        
    }
}