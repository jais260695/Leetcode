public class Solution {
    int[,] dp;
    
    public int Solve(string A, string B, int n, int m,int i, int j)
    {
        if(m==j) return 1;
        if(n==i) return 0;
        
        if(dp[i,j]!=-1) return dp[i,j];
        
        if(A[i]==B[j])
        {
            dp[i,j] = Solve(A,B,n,m,i+1,j+1) + Solve(A,B,n,m,i+1,j);
        }
        else
        {
            dp[i,j] = Solve(A,B,n,m,i+1,j);
        }
        
        return dp[i,j];
    }
    
    public int NumDistinct(string A, string B) {
        int n  = A.Count();
        int m = B.Count();
        
        dp = new int[n,m];
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                dp[i,j] = -1;
            }
        }
        
        return Solve(A,B,n,m,0,0);
    }
}