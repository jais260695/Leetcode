public class Solution {
    SortedSet<string> res = new SortedSet<string>(StringComparer.Ordinal);
    
    public void DFS(Dictionary<string,List<string>> graph, string u, Dictionary<string,bool> visited)
    {
        visited[u]  =true;
        res.Add(u);
        foreach(var acc in graph[u])
        {
            if(!visited[acc])
            {
                DFS(graph, acc, visited);
            }
        }   
    }
    
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts) {
        Dictionary<string,List<string>> graph = new Dictionary<string,List<string>>();
        Dictionary<string,bool> visited = new Dictionary<string,bool>();
        foreach(var acc in  accounts)
        {
            if(!graph.ContainsKey(acc[1]))
            {
                graph.Add(acc[1], new List<string>());
            }
            if(!visited.ContainsKey(acc[1]))
            {
                visited.Add(acc[1], false);
            }
            int n = acc.Count();
            for(int i=2;i<n;i++)
            {
                graph[acc[1]].Add(acc[i]);
                if(!graph.ContainsKey(acc[i]))
                {
                    graph.Add(acc[i], new List<string>());
                }
                graph[acc[i]].Add(acc[1]);
                if(!visited.ContainsKey(acc[i]))
                {
                    visited.Add(acc[i], false);
                }
            }
            
        }
        
        List<List<string>> result = new List<List<string>>();
        foreach(var acc in accounts)
        {
            string name = acc[0];
            int n = acc.Count();
            if(!visited[acc[1]])
            {
               res.Clear();
               DFS(graph,acc[1],visited);
               List<string> temp = new List<string>(res);
               temp.Insert(0,name);
               result.Add(temp);
            }
        }        
        return result.ToList<IList<string>>();  
    }
}