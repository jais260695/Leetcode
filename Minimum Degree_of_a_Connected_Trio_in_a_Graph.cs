public class Solution {
    public int MinTrioDegree(int n, int[][] edges) {
        int m = edges.Count();//number of edges
        int[] degree = new int[n];
        int[,] graph = new int[n,n];
        
        for(int i=0;i<m;i++)
        {
            int u = edges[i][0]-1;
            int v = edges[i][1]-1;
            graph[u,v] = 1;
            graph[v,u] = 1;
            
            degree[u]++;
            degree[v]++;
        }
        
        int ans = int.MaxValue;
        for(int i=0;i<n-2;i++)
        {
            for(int j=i+1;j<n-1;j++)
            {
                if(graph[i,j]==1)
                {
                    for(int k=j+1;k<n;k++)
                    {
                        if(graph[j,k]==1 && graph[i,k]==1)
                        {
                            ans = Math.Min(ans,degree[i]+degree[j]+degree[k]-6);
                        }
                    }
                }
            }
        }
        
        if(ans == int.MaxValue) return -1;
        return ans;
        
    }
}