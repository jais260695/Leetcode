public class Solution {
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) {
        List<int> result = new List<int>();
        int[] inDegree = new int[n];
        int m = edges.Count();
        for(int i=0;i<m;i++)
        {
            inDegree[edges[i][1]]++;
        }
        
        for(int i=0;i<n;i++)
        {
            if(inDegree[i]==0)
            {
                result.Add(i);
            }
        }
        
        return result;
    }
}