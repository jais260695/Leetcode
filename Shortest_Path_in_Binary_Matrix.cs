public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        if(grid.Count()==0 || grid[0][0]==1) return -1; 
        
        int n = grid.Count();
        int level = 0;
        
        Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
        queue.Enqueue(new Tuple<int,int>(0,0));
        
        int[] x = new int[8]{0,0,1,-1,-1,1,-1,1};
        int[] y = new int[8]{1,-1,0,0,-1,1,1,-1};
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            
            while(size>0)
            {
                Tuple<int,int> temp = queue.Dequeue();
                
                int u = temp.Item1;
                int v = temp.Item2;
                
                if(u==n-1 && v==n-1) return level+1;
                
                for(int i=0;i<8;i++)
                {
                    int u1 = u+x[i];
                    int v1 = v+y[i];
                    if( u1>=0 && u1<n && v1>=0 && v1<n && grid[u1][v1] == 0)
                    {
                        queue.Enqueue(new Tuple<int,int>(u1,v1));
                        grid[u1][v1] = -1;
                    }
                }
                
                size--;
            }
            level++;
        }
        return -1;
    }
}