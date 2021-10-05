public class Solution {
    List<List<int>> res = new List<List<int>>();
    public void DFS(int u, int[][] graph, List<int> li, int n)
    {
        if(u==n)
        {
            li.Add(u);
            res.Add(new List<int>(li));
            li.Remove(u);
            return;
        }
        
        li.Add(u);
        
        for(int i=0;i<graph[u].Count();i++)
        {
            DFS(graph[u][i], graph, li, n);
        }
        
        li.Remove(u);
        
    }
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        int n = graph.Count()-1;
        DFS(0,graph,new List<int>(),n);
        return res.ToList<IList<int>>();
    }
}