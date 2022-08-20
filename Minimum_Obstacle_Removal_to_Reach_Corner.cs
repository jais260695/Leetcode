public class Solution {
    int N;
    int[,] dp;
    public int MinimumObstacles(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        
        dp = new int[n,m];
        
        int[] xDir = new int[4]{0,0,1,-1};
        int[] yDir = new int[4]{1,-1,0,0};   
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                dp[i,j] = int.MaxValue;
            }
        }
        
        PriorityQueue<Tuple<int,int>,int> queue = new PriorityQueue<Tuple<int,int>,int>();
        
        queue.Enqueue(new Tuple<int,int>(0,0),0);
        
        dp[0,0] = 0;
        
        while(queue.TryDequeue(out Tuple<int,int> u, out int dist))
        {
                
            int j = u.Item2;
            int i = u.Item1;

            for(int d = 0; d<4; d++)
            {
                int x = i + xDir[d];
                int y = j + yDir[d];

                if(x<0 || x>=n || y<0 || y>=m) continue;

                int v = x*m + y;

                if(dp[x,y] > grid[x][y] + dist)
                {
                    dp[x,y] = grid[x][y] + dist;                        
                    queue.Enqueue(new Tuple<int,int>(x,y),dp[x,y]);
                }
            }
                
        }
        
        return dp[n-1, m-1];
    }
}