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
        int[] xDir = new int[4]{0,0,1,-1};
        int[] yDir = new int[4]{1,-1,0,0};
        Queue<Pair> queue = new Queue<Pair>();
        bool isFreshOrange = false;
        int totalOranges = 0;
        for(int i=0;i<n;i++)
        {
            for(int j =0 ;j<m;j++)
            {
                if(grid[i][j]==2)
                {
                    queue.Enqueue(new Pair(i,j));
                    grid[i][j] = -1;
                    totalOranges++;
                }
                else if(grid[i][j]==1)
                {
                    isFreshOrange = true;
                    totalOranges++;
                }
            }
        }
        
        if(!isFreshOrange) return 0;
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            totalOranges-=size;
            while(size>0)
            {
                Pair p = queue.Dequeue();
                for(int d=0;d<4;d++)
                {
                    int x = p.i+xDir[d];
                    int y = p.j+yDir[d];
                    if(x>=n || y>=m || x<0 || y<0 || grid[x][y]!=1) continue;
                    grid[x][y] = -1;
                    queue.Enqueue(new Pair(x,y));
                }
                size--;
            }
            time++;
        }
        
        return totalOranges>0 ? -1 : time-1;
    }
}