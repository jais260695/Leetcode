public class Solution {    
    public class Pair
    {
        public int i;
        public int j;
        public Pair(int a, int b)
        {
            i = a;
            j = b;
        }
    }
    
    public int OrangesRotting(int[][] grid) {
      
        int n = grid.Count();
        int m = grid[0].Count();
        int time = 0;
        Queue<Pair> queue = new Queue<Pair>();
        for(int i=0;i<n;i++)
        {
            for(int j =0 ;j<m;j++)
            {
                if(grid[i][j]==2)
                {
                    queue.Enqueue(new Pair(i,j));
                    grid[i][j] = -1;
                }
            }
        }
            queue.Enqueue(new Pair(-1,-1));
            
            while(queue.Count()>0)
            {
                Pair p = queue.Dequeue();
                
                if(p.i==-1)
                {
                    time++;
                    if(queue.Count()>0)
                    {
                        queue.Enqueue(new Pair(-1,-1));
                    }
                    continue;
                }
                
                if(p.i+1<n && grid[p.i+1][p.j]==1)
                {
                    grid[p.i+1][p.j] = -1;
                    queue.Enqueue(new Pair(p.i+1,p.j));
                }
                if(p.i-1>=0 && grid[p.i-1][p.j]==1)
                {
                    grid[p.i-1][p.j] = -1;
                    queue.Enqueue(new Pair(p.i-1,p.j));
                }
                if(p.j+1<m && grid[p.i][p.j+1]==1)
                {
                    grid[p.i][p.j+1] = -1;
                    queue.Enqueue(new Pair(p.i,p.j+1));
                }
                if(p.j-1>=0 && grid[p.i][p.j-1]==1)
                {
                    grid[p.i][p.j-1] = -1;
                    queue.Enqueue(new Pair(p.i,p.j-1));
                }
            }
            
        for(int i=0;i<n;i++)
        {
            for(int j =0 ;j<m;j++)
            {
                if(grid[i][j]==1)
                {
                    return -1;
                }
            }
        }
        
        return time-1;
    }
}