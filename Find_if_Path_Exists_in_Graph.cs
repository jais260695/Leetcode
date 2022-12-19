public class Solution {
    void DFS(int u,List<int>[] adjList,bool[] visited){
        visited[u] = true;

        foreach(int v in adjList[u])
        {
            if(!visited[v])
            {
                DFS(v,adjList,visited);
            }
        }

    }
    public bool ValidPath(int n, int[][] edges, int start, int end) {
        List<int>[] adjList = new List<int>[n];

        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
        }

        foreach(int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            adjList[u].Add(v);
            adjList[v].Add(u);
        }

        bool[] visited = new bool[n];

        DFS(start,adjList,visited);

        return visited[end];
    }
}