public class Solution {
    public int[] parent;
    public int[] rank;
    public int Find(int i)
    {
        if(parent[i]==i)
        {
            return i;
        }
        return parent[i] = Find(parent[i]);
    }
    public void Union(int x, int y)
    {
        x = Find(x);
        y = Find(y);  
        if(rank[x]==rank[y])
        {
            parent[y] = x;
            rank[x]++;
        }
        else if(rank[x]>rank[y])
        {
             parent[y] = x;
        }
        else
        {
            parent[x] = y;
        }
    }
    public int LatestDayToCross(int row, int col, int[][] cells) {
        int n = cells.Count();
        bool[,] isLand = new bool[row,col];
        int[] xDir = new int[4]{0,1,-1,0};
        int[] yDir = new int[4]{1,0,0,-1};
        parent = new int[n+2];
        rank = new int[n+2];
        for(int i=0;i<n+2;i++)
        {
            parent[i] = i;
        }        
        for(int i=0;i<col;i++)
        {
            int u = i;
            int v = n;
            parent[u] = v;
            rank[v]++;   
        }
        
        for(int i=0;i<col;i++)
        {
            int u = (row-1)*col+i;
            int v = n+1;
            parent[u] = v;
            rank[v]++;   
        }
        
        for(int i=n-1;i>=0;i--)
        {
            int x = cells[i][0] - 1;
            int y = cells[i][1] - 1;
            isLand[x,y] = true;
            for(int d=0;d<4;d++)
            {
                int xN = x + xDir[d];
                int yN = y + yDir[d];
                if(xN>=0 && xN<row && yN>=0 && yN<col && isLand[xN,yN])
                {
                    int u = Find(x*col + y);
                    int v = Find(xN*col + yN);
                    if(u!=v)
                    {
                        Union(u,v);
                    }
                    if(Find(n)==Find(n+1)) return i;
                }
            }
        }
        return -1;
    }
}