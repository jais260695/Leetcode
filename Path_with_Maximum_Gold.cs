public class Solution {
    int[] xDir = new int[4]{0,0,1,-1};
    int[] yDir = new int[4]{1,-1,0,0};
    
    public int FindMax(int i, int j, int[][] grid, int n, int m)
    {
            grid[i][j]=(-1)*grid[i][j];
            int max = 0;            
            for(int d=0;d<4;d++)
            {
                int x = i+xDir[d];
                int y = j+yDir[d];
                if(x<0 || x>=n || y<0 || y>=m || grid[x][y]<=0) continue;
                int tempRes =  FindMax(x,y,grid,n,m);
                if(max<tempRes)
                {
                    max = tempRes;
                }
            }
            grid[i][j]=(-1)*grid[i][j];
            return max + grid[i][j];                
    }
    
    public int GetMaximumGold(int[][] grid) {
        int n=grid.Count();
        int m = grid[0].Count();
        int max =0;
        for(int i=0;i<n;i++)
        {
            for(int j =0;j<m;j++)
            {
                if(grid[i][j]!=0)
                {
                    int res = FindMax(i,j,grid,n,m);
                    if(res>max)
                    {
                        max=res;
                    }
                }            
            }
        }
        return max;
    }
}