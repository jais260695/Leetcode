public class Solution {
    public int[] x = new int[]{0,0,1,-1};
    public int[] y = new int[]{1,-1,0,0};
    public void DFS(int u, int v,bool[,] visited, bool[,] dp, int n, int m,int[][] matrix)
    {
        visited[u,v] = true;
        
        for(int i=0;i<4;i++)
        {
            int u1 = u + x[i];
            int v1 = v + y[i];
            if(u1>=0 && u1<n && v1>=0 && v1<m && !visited[u1,v1] && matrix[u1][v1]>=matrix[u][v])
            {
                dp[u1,v1] = true;
                DFS(u1,v1,visited,dp,n,m,matrix);
            }
        }
        
    }
    public IList<IList<int>> PacificAtlantic(int[][] matrix) {
        int n = matrix.Count();
        List<List<int>> res = new List<List<int>>();
        if(n==0) return res.ToList<IList<int>>();
        int m = matrix[0].Count();
        bool[,] visited = new bool[n,m];
        bool[,] dp1 = new bool[n,m];
        bool[,] dp2 = new bool[n,m];
        
        for(int j=0;j<m;j++)
        {
            dp1[0,j] = true;
            DFS(0,j,visited,dp1,n,m,matrix);
        }
        
        for(int i=1;i<n;i++)
        {
            dp1[i,0] = true;
            DFS(i,0,visited,dp1,n,m,matrix);
        }
        
        visited = new bool[n,m];
        
        for(int j=0;j<m;j++)
        {
            dp2[n-1,j] = true;
            DFS(n-1,j,visited,dp2,n,m,matrix);
        }
        
        for(int i=0;i<n-1;i++)
        {
            dp2[i,m-1] = true;
            DFS(i,m-1,visited,dp2,n,m,matrix);
        }
        
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(dp1[i,j]==true && dp2[i,j]==dp1[i,j])
                {
                    res.Add(new List<int>(){i,j});
                }
            }
        }
        return res.ToList<IList<int>>();
    }
}