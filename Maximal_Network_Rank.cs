public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) {
        List<int>[] adj = new List<int>[n];   
        for(int i=0;i<n;i++)
        {
            adj[i] = new List<int>();
        }       
        int ans = 0;
        for(int i=0;i<roads.Count();i++)
        {
            adj[roads[i][0]].Add(roads[i][1]);
            adj[roads[i][1]].Add(roads[i][0]);
        }  
        
        for(int i=0;i<n-1;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                int temp = adj[i].Count()+adj[j].Count();
                if(adj[i].Contains(j))
                {
                    temp--;
                }
                if(ans<temp) ans = temp;
            }
        }
        
        return ans;
    }
}