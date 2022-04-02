public class Solution {
    
    public bool IsExit (int i, int j ,int n, int m)
    {
        return i==0 || j==0 || i==n-1 || j== m-1;
    }
    public int NearestExit(char[][] maze, int[] entrance) {
        int n = maze.Count();
        int m = maze[0].Count();
        
        int[] xDir = new int[4]{0,0,1,-1};
        int[] yDir = new int[4]{1,-1,0,0};
        
        Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
        queue.Enqueue(new Tuple<int,int>(entrance[0],entrance[1]));
        maze[entrance[0]][entrance[1]] = '-';
        
        int level = 0;
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                Tuple<int,int> q = queue.Dequeue();
                
                for(int d = 0; d<4; d++)
                {
                    int x = q.Item1 + xDir[d];
                    int y = q.Item2 + yDir[d];
                    
                    if(x<0 || x>=n || y<0 || y>=m || maze[x][y]!='.') continue;
                    maze[x][y]='-';
                    if(IsExit(x,y,n,m)) return level+1;
                    queue.Enqueue(new Tuple<int,int>(x,y));
                }
                
                size--;
            }
            level++;
        }
        return -1;
    }
}