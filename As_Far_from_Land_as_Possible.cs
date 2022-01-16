public class Solution {
    public int MaxDistance(int[][] grid) {
        int n = grid.Count();
        Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();

        int[] xDir = new int[4]{0,0,1,-1};
        int[] yDir = new int[4]{1,-1,0,0,};
        
        bool[,] visited = new bool[n,n];
        
        bool water = false;
        bool land = false;
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j] == 1)
                {
                    land = true;
                    queue.Enqueue(new Tuple<int,int>(i,j));
                    visited[i,j] = true;
                }
                else
                {
                    water = true;
                }
            }
        }
        if(!water || !land) return -1;
        int res = 0;
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                Tuple<int,int> temp = queue.Dequeue();
                int i = temp.Item1;
                int j = temp.Item2;
                
                for(int d=0;d<4;d++)
                {
                    int x = i+xDir[d];
                    int y = j+yDir[d];
                    if(x<0 || x>=n || y<0 || y>=n || visited[x,y]) continue;
                    queue.Enqueue(new Tuple<int,int>(x,y));
                    visited[x,y] = true;
                }
                
                size--;
            }
            res++;
        }
        
        return res-1;
    }
}