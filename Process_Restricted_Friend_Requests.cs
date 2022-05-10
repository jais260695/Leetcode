public class Solution {
    int[] parent;
    int[] rank;
    public int Find(int u)
    {
        if(parent[u]==u)
        {
            return u;
        }
        
        return parent[u] = Find(parent[u]);
    }
    
    public void Union(int u, int v)
    {
        int x = Find(u);
        int y = Find(v);
        
        if(rank[x]>rank[y])
        {
            parent[y] = x;
        }
        else if(rank[x]<rank[y])
        {
            parent[x] = y;
        }
        else
        {
            parent[x] = y;
            rank[y]++;
        }
    }
    public bool[] FriendRequests(int n, int[][] restrictions, int[][] requests) {
        parent = new int[n];
        rank = new int[n];
        
        for(int i=0;i<n;i++)
        {
            parent[i] = i;
        }
        
        int totalRestrictions = restrictions.Count();
        int totalRequests = requests.Count(); 
        
        bool[] result = new bool[totalRequests];
        
        for(int currentRequest=0;currentRequest<totalRequests;currentRequest++)
        {
            int u = Find(requests[currentRequest][0]);
            int v = Find(requests[currentRequest][1]);
            
            if(u==v)
            {
                result[currentRequest] = true;
                continue;
            }
            
            int currentRestrict = 0;
            for( ;currentRestrict<totalRestrictions; currentRestrict++)
            {
                int x = Find(restrictions[currentRestrict][0]);
                int y = Find(restrictions[currentRestrict][1]);
                
                if((u==x && v==y) || (u==y && v==x))
                {
                    result[currentRequest] = false;
                    break;
                }
            }
            
            if(currentRestrict==totalRestrictions)
            {
                result[currentRequest] = true;
                Union(u,v);
            }
        }
        
        return result;
    }
}