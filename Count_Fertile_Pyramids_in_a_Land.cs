public class Solution {
    public int CountPyramids(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        
        int[,] dp1 = new int[n,m];
        int[,] dp2 = new int[n,m];
        
        for(int i=0;i<n;i++)
        {
  
            for(int j=0;j<m;j++)
            {
                    dp1[i,j] = grid[i][j];
                    dp2[i,j] = grid[i][j];
            }
        }
        
        int result = 0;
        
        for(int i=n-1;i>=0;i--)
        {
            int ri = (n-1)-i;
            
            for(int j=1;j<m-1;j++)
            {
                if(i!=n-1)
                {
                    if(dp1[i,j]==1)
                    {
                        int min = Math.Min(Math.Min(dp1[i+1,j-1],dp1[i+1,j]),dp1[i+1,j+1]);
                        if(min!=0)
                        {
                            dp1[i,j]=1+min;
                            
                            result+=(dp1[i,j]-1);
                        }
                    }
                }
                
                if(ri!=0)
                {
                    if(dp2[ri,j]==1)
                    {
                        int min = Math.Min(Math.Min(dp2[ri-1,j-1],dp2[ri-1,j]),dp2[ri-1,j+1]);
                        if(min!=0)
                        {
                            dp2[ri,j]=1+min;
                            
                            result+=(dp2[ri,j]-1);
                        }
                    }
                }
                
            }
        }
        
        return result;
    }
}