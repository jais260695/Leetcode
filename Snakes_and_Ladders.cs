public class Solution {
    public class Pair
    {
        public int pos;
        public int dist;
        public Pair(int p, int d)
        {
            pos = p;
            dist =d;
        }
    }
    public int SnakesAndLadders(int[][] board) {
        int n = board.Count();
        int[] dp = new int[n*n+1];
        int flag = 0;
        int index = 1;
        for(int i=n-1;i>=0;i--)
        {
            if(flag==0)
            {
                for(int j=0;j<n;j++)
                {
                    dp[index] = board[i][j];
                    index++;
                }
                flag = 1;
            }
            else
            {
                for(int j=n-1;j>=0;j--)
                {
                    dp[index] = board[i][j];
                    index++;
                }
                flag = 0;
            }            
        }
        Queue<Pair> queue = new Queue<Pair>();
        bool[] visited = new bool[n*n+1];
        for(int i=0;i<=n*n;i++)
        {
            visited[i]=false;
        }
        visited[1]=true;
        queue.Enqueue(new Pair(1,0));
        while(queue.Count()>0)
        {
            Pair p=queue.Dequeue();
            int v = p.pos;
            int d = p.dist;
            if(v == n*n) return d;
            
            for(int i=v+1;i<=v+6 && i<=n*n;i++)
            {
                if(!visited[i])
                {
                    visited[i] = true;
                    if(dp[i]!=-1)
                    {
                        queue.Enqueue(new Pair(dp[i],d+1));
                    }
                    else
                    {
                        queue.Enqueue(new Pair(i,d+1));
                    }
                }
            }    
        }
        return -1;
    }
}