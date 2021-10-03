public class Solution {
    
    public int Find(int i, int[] parent)
    {
        while(parent[i]!=-1)
        {
            i = parent[i];
        }
        return i;
    }
    
    public void Union(int i, int j, int[] parent)
    {
        parent[i]= j ;
    }
    public int FindCircleNum(int[][] M) {
        int n = M.Count();
        int[] parent = new int[n];
        
        for(int i=0;i<n;i++)
        {
            parent[i] = -1;
        }
        int c= 0;
        for(int i=0;i<n;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                if(M[i][j]==1)
                {
                    int x = Find(i,parent);
                    int y = Find(j,parent);
                    if(x!=y)
                    {
                        
                        Union(x,y,parent);
                    }
                }
            }
        }
        for(int i=0;i<n;i++)
        {
            if(parent[i] == -1)
            {
                c++;
            }
        }
        return c;
        
    }
}