public class Solution {
    int[] xDir = new int[4]{0,0,1,-1};
    int[] yDir = new int[4]{1,-1,0,0};
    Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
    
    public void DFS(int[][] grid, int i, int j, int n)
    {
        
        grid[i][j] =  2;
        
        queue.Enqueue(new Tuple<int,int>(i,j));
        
        for(int d=0;d<4;d++)
        {
            int x = i + xDir[d];
            int y = j + yDir[d];
            
            if(x<0 || x>=n || y<0 || y>=n || grid[x][y]!=1) continue;
            DFS(grid,x,y,n);
        }
    }
    public int ShortestBridge(int[][] grid) {
        
        int n = grid.Count();
        for(int i=0; i<n; i++)
        {
            int j = 0;
            for(; j<n; j++)
            {
                if(grid[i][j]==1)
                {
                    DFS(grid,i,j,n);
                    break;
                }
            }
            if(j<n) break;
        }
        
        int level = 0;
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                Tuple<int, int> coord = queue.Dequeue();
                for(int d=0;d<4;d++)
                {
                    int x = coord.Item1 + xDir[d];
                    int y = coord.Item2 + yDir[d];

                    if(x<0 || x>=n || y<0 || y>=n || grid[x][y]==2) continue;
                    if(grid[x][y]==1)
                    {
                        return level;
                    }
                    grid[x][y] = 2;
                    queue.Enqueue(new Tuple<int,int>(x,y));
                }
                
                size--;
            }
            level++;
        }
        
        return level;
    }
}