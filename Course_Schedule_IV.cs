public class Solution {

    public IList<bool> CheckIfPrerequisite(int n, int[][] prerequisites, int[][] queries) {
        bool[,] graph = new bool[n,n];
        for(int i = 0;i< prerequisites.Count();i++)
        {
            graph[ prerequisites[i][0], prerequisites[i][1] ] = true;
        }
      
        List<bool> result = new List<bool>();
        for(int k = 0; k < n; k++) {
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    graph[i,j] |= graph[i,k] && graph[k,j];
                }
            }
        }
        for(int i =0;i<queries.Count();i++)
        {
            result.Add(graph[queries[i][0],queries[i][1]]);
        }
        return result.ToList<bool>();
    }
}