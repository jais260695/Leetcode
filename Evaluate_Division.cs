public class Solution {
    public double DFS(string src, string dst,Dictionary<string,Dictionary<string,double>> graph,Dictionary<string,bool> visited)
    {
        if(src==dst) return 1;
        visited[src] = true;
        double ans = 1;
        foreach(KeyValuePair<string,double> kv in graph[src])
        {
            if(!visited[kv.Key])
            {
                double val = DFS(kv.Key,dst,graph,visited);
                if(val>0)
                {
                    ans*=kv.Value*val;
                    visited[src] = false;
                    return ans;
                }
            }
        }
        visited[src] = false;
        return -1;      
    }
    
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)     {
        Dictionary<string,Dictionary<string,double>> graph= new Dictionary<string,Dictionary<string,double>>();
        int n = equations.Count();
        Dictionary<string,bool> visited = new Dictionary<string,bool>();
        for(int i=0;i<n;i++)
        {
            if(!graph.ContainsKey(equations[i][0]))
            {
                graph.Add(equations[i][0],new Dictionary<string,double>());
                visited.Add(equations[i][0],false);
            }
            if(!graph.ContainsKey(equations[i][1]))
            {
                graph.Add(equations[i][1],new Dictionary<string,double>());
                visited.Add(equations[i][1],false);
            }
            graph[equations[i][0]].Add(equations[i][1],values[i]);
            graph[equations[i][1]].Add(equations[i][0],1/values[i]);
        }
        
        int m = queries.Count();
        double[] res = new double[m];
        
        for(int i=0;i<m;i++)
        {
            if(!graph.ContainsKey(queries[i][0]) || !graph.ContainsKey(queries[i][1]))
            {
                res[i] = -1;
                continue;
            }
            double ans = DFS(queries[i][0],queries[i][1],graph,visited);
            if(ans>0)
                res[i] = ans;
            else
                res[i] = -1;
        }
        return res;
    }
}