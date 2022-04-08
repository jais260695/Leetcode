public class Solution {
    public int[] xDir = new int[4]{0,0,1,-1};
    public int[] yDir = new int[4]{1,-1,0,0};
    
    public void DFS(int[][] land,int n, int m, int i, int j, int color)
    {
        land[i][j] = color;
        
        for(int d = 0;d<4;d++)
        {
            int x = i + xDir[d];
            int y = j + yDir[d];
            if(x<0 || x>=n || y<0 || y>=m || land[x][y]==0 || land[x][y]==color) continue;
            DFS(land,n,m,x,y,color);
        }
    }
    
    public int[][] FindFarmland(int[][] land) {
        int n = land.Count();
        int m = land[0].Count();
        int farmCount = 0;
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(land[i][j]==1)
                {
                    farmCount++;
                    DFS(land,n,m,i,j,farmCount+1);
                }
            }
        }
        
        int[][] result = new int[farmCount][];
        
        for(int i=0;i<farmCount;i++)
        {
            result[i] = new int[4]{-1,-1,-1,-1}; 
        }

        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(land[i][j]!=0)
                {
                    if(result[land[i][j]-2][0]==-1)
                    {
                        result[land[i][j]-2][0] = i;
                        result[land[i][j]-2][1] = j;
                    }
                    result[land[i][j]-2][2] = i;
                    result[land[i][j]-2][3] = j;
                }
            }
        }
        return result;
    }
}