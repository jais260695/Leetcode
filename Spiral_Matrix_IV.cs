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
    int[][] result;
    int M;
    int N;
    void Solve(int R, int C, ListNode head)
    {
        if(M==0 || N==0 || head==null) return;
        
        int c = C;
        int r = R;
        while(head!=null && c < N)
        {
            result[r][c] = head.val;
            head = head.next;
            c++;
        }
        if(head==null) return;
        c=N-1;
        
        r = R+1;
        while(head!=null && r < M)
        {
            result[r][c] = head.val;
            head = head.next;
            r++;
        }
        if(head==null) return;
        r=M-1;
        
        c--;
        while(head!=null && c >= C)
        {
            result[r][c] = head.val;
            head = head.next;
            c--;
        }
        if(head==null) return;
        c=C;
        
        r--;
        while(head!=null && r > R)
        {
            result[r][c] = head.val;
            head = head.next;
            r--;
        }
        if(head==null) return;
        r=R+1;
        
        M--;
        N--;
        
        Solve(R+1,C+1, head);
    }
    public int[][] SpiralMatrix(int m, int n, ListNode head) {
        M = m;
        N = n;
        result = new int[M][];
        for(int i=0;i<M;i++)
        {
            result[i] = new int[N];
            
            for(int j=0;j<N;j++)
            {
                result[i][j] = -1;
            }
        }
        
        Solve(0,0, head);
        return result;
    }
}