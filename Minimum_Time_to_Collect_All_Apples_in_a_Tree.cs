public class Solution {
    bool[] visited;
    int DFS(int u,List<int>[] adjList, IList<bool> hasApple)
    {
        visited[u] = true;
        int result = 0;
        foreach(int v in adjList[u])
        {
            if(!visited[v])
                result+=DFS(v,adjList,hasApple);
        }
        
        return (hasApple[u] || result > 0) && u!=0 ? 2 + result : result;
    }
    public int MinTime(int n, int[][] edges, IList<bool> hasApple) {
        List<int>[] adjList = new List<int>[n];
        visited = new bool[n];
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
        }
        
        for(int i=0;i<n-1;i++)
        {
            int u = edges[i][0];
            int v = edges[i][1];
            adjList[u].Add(v);
            adjList[v].Add(u);
        }
        
        return DFS(0,adjList,hasApple);
    }
}