public class Solution {
    public int[] parent;
    public int[] size;
    public int[] rank;
    
    public int Find(int u)
    {
        if(parent[u]==-1) return u;
        
        return parent[u] = Find(parent[u]);
    }
    
    public void Union(int u, int v)
    {
        int x = Find(u);
        int y = Find(v);
        if(x!=y)
        {
            if(rank[x]<rank[y])
            {
                int temp = x;
                x = y;
                y = temp;
            }
            else if(rank[x]==rank[y])
            {
                rank[x]++;
            }
            parent[y] = x;
            size[x] += size[y];
            
        }
        
    }
    
    public int GCD(int a, int b)
    {
        if(a==0) return b;
        if(a>=b) return GCD(a-b,b);
        return GCD(a,b-a);
    }
    
    public int LargestComponentSize(int[] A) {
        int n = A.Count();
        parent = new int[n];
        size = new int[n];
        rank = new int[n];
        for(int i=0;i<n;i++)
        {
            parent[i] = -1;
            size[i] = 1;
        }
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i=0;i<n;i++)
        {
            for(int j=2;j<=Math.Sqrt(A[i]);j++)
            {
                if(A[i]%j==0)
                {
                    if(!dict.ContainsKey(j))
                    {
                        dict.Add(j,i);
                    }
                    else
                        Union(i,dict[j]);
                    
                    if(!dict.ContainsKey(A[i]/j))
                    {
                        dict.Add(A[i]/j,i);
                    }
                    else 
                        Union(i,dict[A[i]/j]);
                }
            }
            if(!dict.ContainsKey(A[i]))
                dict.Add(A[i],i);
            else
                Union(i,dict[A[i]]);
            
        }
        
        int result = int.MinValue;
        for(int i=0;i<n;i++)
        {
            
            if(parent[i]==-1)
            {   
                result = Math.Max(result,size[i]);
            }
        }
        
            
        return result;
    }
}