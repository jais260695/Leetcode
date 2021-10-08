public class Solution {
    public void DFS(int u,List<int> result,Dictionary<int,List<int>> graph)
    {
        result.Add(u);
        List<int> adjList = graph[u];
        graph.Remove(u);
        foreach(int v in adjList)
        {
            if(graph.ContainsKey(v))
            {
                DFS(v,result,graph);
            }
        }
    }
    public int[] RestoreArray(int[][] adjacentPairs) {
        int n = adjacentPairs.Count();
        Dictionary<int,List<int>> graph = new Dictionary<int,List<int>>();
        for(int i=0;i<n;i++)
        {
            int u = adjacentPairs[i][0];
            int v = adjacentPairs[i][1];
            if(!graph.ContainsKey(u))
            {
                graph.Add(u,new List<int>());
            }
            graph[u].Add(v);
            if(!graph.ContainsKey(v))
            {
                graph.Add(v,new List<int>());
            }
            graph[v].Add(u);
        }
        int s = 0;
        foreach(KeyValuePair<int,List<int>> kvp in graph)
        {
            if(kvp.Value.Count()==1) {
                s = kvp.Key;
                break;
            }
        }
        List<int> result = new List<int>();
        DFS(s,result,graph);
        return result.ToArray();
    }
}