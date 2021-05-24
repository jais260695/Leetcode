public class Solution {
    public int time = 0;
    public void DFS(int u, List<int>[] adj, int[] desc, int[] low, bool[] visited, int[] parent,List<List<int>> res)
    {
        visited[u] = true;
        desc[u] = low[u] = time;
        time++;
        int children = 0;
        foreach(int v in adj[u])
        {
            if(!visited[v])
            {
                children++;
                parent[v] = u;
                DFS(v,adj,desc,low,visited,parent,res);
                low[u] = Math.Min(low[u],low[v]);
                if(low[v]>desc[u])
                {
                    res.Add(new List<int>{u,v});
                }
            }
            else
            {
                if(parent[u] != v)
                {
                    low[u] = Math.Min(low[u],desc[v]);
                }
            }
        }
    }
    public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections) {
        List<int>[] g = new List<int>[n];
        List<List<int>> res = new List<List<int>>();
        int[] desc = new int[n];
        int[] low = new int[n];
        bool[] visited = new bool[n];
        int[] parent = new int[n];
        for(int i =0;i<n;i++)
        {
            parent[i] = -1;
            g[i] = new List<int>();
        }
        
        foreach(List<int> l in connections)
        {
            g[l[0]].Add(l[1]);
            g[l[1]].Add(l[0]);
        }       
        
        DFS(0,g,desc,low,visited,parent,res);
        return res.ToList<IList<int>>();
    }
}