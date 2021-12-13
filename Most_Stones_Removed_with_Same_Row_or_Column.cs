public class Solution {
    public void DFS(List<int>[] adj, int u, bool[] visited)
    {
        visited[u] = true;
        foreach(int v in adj[u])
        {
            if(!visited[v])
            {
                 DFS(adj,v,visited);
            }
        }
    }
    public int RemoveStones(int[][] stones) {
        //use UNION FIND with Path Compression for better time complexity
        int n = stones.Count();
        List<int>[] adj = new List<int>[n];
        for(int i=0;i<n;i++)
        {
            adj[i] = new List<int>();
        }
        for(int i=0;i<n-1;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                if(stones[i][0]==stones[j][0] || stones[i][1]==stones[j][1])
                {
                    adj[i].Add(j);
                    adj[j].Add(i);
                }
            }
        }
        
        bool[] visited = new bool[n];
        int count = 0;
        for(int i=0;i<n;i++)
        {
            if(!visited[i])
            {
                count++;
                DFS(adj,i,visited);
            }
        }
        return n-count;
    }
}