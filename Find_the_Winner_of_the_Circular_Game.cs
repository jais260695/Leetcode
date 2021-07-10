public class Solution {
    List<int> list = new List<int>();
    public void Solve(int i, int k,int n)
    {
        if(n==1) return;
        int next = (i+k)%n;
        
        list.RemoveAt(next);
        
        Solve(next,k,n-1);
    }
    public int FindTheWinner(int n, int k) {
        
        for(int i=1;i<=n;i++)
        {
            list.Add(i);
        }
        
        Solve(0,k-1,n);
        
        return list[0];
    }
}