public class Solution {
    public class Pair
    {
        public int x;
        public int y;
        public Pair(int u, int v)
        {
            x = u;
            y = v;
        }
    }
    public int[][] UpdateMatrix(int[][] mat) {
        int n = mat.Count();
        int m = mat[0].Count();
        int[][] result = new int[n][];
        Queue<Pair> queue = new Queue<Pair>();
        for(int i=0;i<n;i++)
        {
            result[i] = new int[m];
            for(int j=0;j<m;j++)
            {
                if(mat[i][j]==0)
                {
                    queue.Enqueue(new Pair(i,j));
                }
                else
                {
                    result[i][j] = -1;
                }
            }
        }
        int level = 0;
        int[] xDir = {0,0,1,-1};
        int[] yDir = {1,-1,0,0};
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                Pair p = queue.Dequeue();
                for(int i=0;i<4;i++)
                {
                    int x = p.x + xDir[i];
                    int y = p.y + yDir[i];
                    if(x<0 || x>=n || y<0 || y>=m || result[x][y]!=-1) continue;
                    result[x][y] = level+1;
                    queue.Enqueue(new Pair(x,y));
                }
                size--;
            }
            level++;
        }
        return result;
    }
}