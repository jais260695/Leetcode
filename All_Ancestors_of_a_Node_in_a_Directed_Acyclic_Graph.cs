public class Solution {
    
    List<int>[] adjList;
    List<List<int>> result;
    bool[] visited;
    
    public void DFS(int u)
    {
        visited[u] = true;
        
        foreach(int v in adjList[u])
        {
            if(!result[u].Contains(v))
                result[u].Add(v);
            if(!visited[v])
            {
                DFS(v);
            }
            
            foreach(int w in result[v])
            {
                if(!result[u].Contains(w))
                    result[u].Add(w);
            }
        }
        
        result[u].Sort();
    }
    
    public IList<IList<int>> GetAncestors(int n, int[][] edges) {
        
        adjList = new List<int>[n];
        result = new List<List<int>>();
        visited = new bool[n];
        
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
            result.Add(new List<int>());
        }
        
        int m = edges.Count();
        
        for(int i=0;i<m;i++)
        {
            int u = edges[i][0];
            int v = edges[i][1];
            
            adjList[v].Add(u);
        }
        
        for(int i=0;i<n;i++)
        {
            if(!visited[i])
            {
                DFS(i);
            }
        }
        
        return result.ToList<IList<int>>();
    }
}