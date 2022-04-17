public class Solution {
    public int[][] ColorBorder(int[][] grid, int row, int col, int color) {
        int n = grid.Count();
        int m = grid[0].Count();
        int[] xDir = new int[4]{0,0,1,-1};
        int[] yDir = new int[4]{1,-1,0,0};
        
        bool[,] visited = new bool[n,m];
        
        Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();      
        queue.Enqueue(new Tuple<int,int>(row,col));
        visited[row,col] = true;
        
        int c = grid[row][col];
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                Tuple<int,int> curr = queue.Dequeue();
                int i = curr.Item1;
                int j = curr.Item2;
                
                for(int d=0;d<4;d++)
                {
                    int x = i+xDir[d];
                    int y = j+yDir[d];
                    if(x<0 || x>=n || y<0 || y>=m)
                    {
                        
                        grid[i][j] = color;
                        continue;
                    }
                    
                    if(!visited[x,y] && grid[x][y]!=c)
                    {
                        grid[i][j] = color;
                        continue;
                    }
                    
                    if(visited[x,y]) continue;

                    queue.Enqueue(new Tuple<int,int>(x,y));
                    visited[x,y]  = true;
                }
                size--;
            }
        }
        
        return grid;
    }
}