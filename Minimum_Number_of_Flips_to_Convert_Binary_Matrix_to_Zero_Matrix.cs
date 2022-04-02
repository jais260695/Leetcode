public class Solution {
    public int MinFlips(int[][] mat) {
        int  m  = mat.Count();
        int n = mat[0].Count();
        int mask = 0;
        int[] xDir = new int[4]{0,0,1,-1};
        int[] yDir = new int[4]{1,-1,0,0}; 
        
        //Calculate mask for matrix where  (row*n+col)th bit is set if mat[row][col] = 1
        for(int i = 0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                int s = i*n + j;
                mask |= (mat[i][j]<<s);
            }
        }
        
        
        
        //Total masks possible are 2^(m*n)
        int total = (int) Math.Pow(2,m*n);
        bool[] visited = new bool[total];
        
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(mask);
        visited[mask] = true;
        int level = 0;
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                int u = queue.Dequeue();
                if(u==0) return level;
                for(int i=0;i<m;i++)
                {
                    for(int j=0;j<n;j++)
                    {
                        // (i*n+j)th bit will be flipped by using XOR with 1 at (i*n+j)th position, if bit is 0 then (0^1) = 1 else (1^1) = 0,
                        int newMask = u^(1<<(i*n+j));
                        for(int d = 0;d<4;d++)
                        {
                            int x = xDir[d] + i;
                            int y = yDir[d] + j;
                            if(x<0 || y<0 || x>=m || y>=n) continue;
                            //Similarly flip the adjacent bits of (i,j) in matrix
                            newMask ^= (1<<(x*n+y));
                        }
                        
                        if(!visited[newMask])
                        {
                            queue.Enqueue(newMask);
                            visited[newMask] = true;
                        }
                    }
                }

                size--;
            }
            level++;
        }
        return -1;
    }
}