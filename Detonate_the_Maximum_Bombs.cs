public class Solution {
    public bool IsOverlap(int[] a, int[] b)
    {
        var X = Math.Pow(a[0]-b[0],2);
        var Y = Math.Pow(a[1]-b[1],2);
        
        var D = Math.Sqrt(X+Y);
        
        var r = a[2];
        
        return D<=r;
    }
    public int DFS(int i, List<int>[] adjList, bool[] visited)
    {
        visited[i] = true;
        int result = 1;
        foreach(int v in adjList[i])
        {
            if(!visited[v])
            {
                result+=DFS(v,adjList,visited);
            }
        }
        return result;
    }
    
    public int MaximumDetonation(int[][] bombs) {
        int n = bombs.Count();
        
        List<int>[] adjList = new List<int>[n];
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
        }
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(i!=j && IsOverlap(bombs[i],bombs[j]))
                {
                    adjList[i].Add(j);
                }
            }
        }
        
        int ans = 0;
        
        for(int i=0;i<n;i++)
        {
                bool[] visited  = new bool[n];
                ans = Math.Max(DFS(i,adjList,visited),ans);
        }
        
        return ans;
    }
}