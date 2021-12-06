public class Solution {
    public void DFS(int[][] A, int i,int j,int n,int m)
    {
        A[i][j] = 0;
        
        if(i+1<n && A[i+1][j]==1)
        {
            DFS(A,i+1,j,n,m);
        }
        if(i-1>=0 && A[i-1][j]==1)
        {
            DFS(A,i-1,j,n,m);
        }
        if(j+1<m && A[i][j+1]==1)
        {
            DFS(A,i,j+1,n,m);
        }
        if(j-1>=0 && A[i][j-1]==1)
        {
            DFS(A,i,j-1,n,m);
        }
    }
    public int NumEnclaves(int[][] A) {
        int n = A.Count();
        int m = A[0].Count();
        for(int i=0;i<n;i++)
        {
            if(A[i][0]==1)
                DFS(A,i,0,n,m);
            if(A[i][m-1]==1)
                DFS(A,i,m-1,n,m);
        }
        
        for(int j=1;j<m-1;j++)
        {
            if(A[0][j]==1)
                DFS(A,0,j,n,m);
            if(A[n-1][j]==1)
                DFS(A,n-1,j,n,m);
        }
        
        int c=0;
        for(int i=1;i<n-1;i++)
        {
            for(int j=1;j<m-1;j++)
            {
                if(A[i][j]==1) c++;
            }
        }
        return c;
    }
}