public class Solution {
    List<int>[] adjList;
    bool[] visited;
    List<int> res = new List<int>();
    public bool DFS(int u)
    {
        visited[u] = true;
        int count=0;
        foreach(int v in adjList[u])
        {
            if(!visited[v])
            {
                if(!DFS(v))
                {
                    count++;
                }
            }
            else
            {
                if(!res.Contains(v))
                {
                    count++;
                }
            }
        }
        if(count==0) 
        {
            res.Add(u);
            return true;
        }
        return false;
    }
    public IList<int> EventualSafeNodes(int[][] graph) {

        // Can also be solved using outdegree and then selecting the vertices with outdegree 0 
        // store them in result and decrement the outdegree from the head of the edges pointing to the 0 outdegree vertices
        // keep on doing till the algo gives 0 outdegree vertices
        int n = graph.Count();
        adjList = new List<int>[n];
        visited = new bool[n];
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
            int m = graph[i].Count();
            for(int j=0;j<m;j++)
            {
                adjList[i].Add(graph[i][j]);
            }
        }
        for(int i=0;i<n;i++)
        {
            if(!visited[i])
            {
                DFS(i);
            }
        }
        res.Sort();
        return res.ToList<int>();
    }
}