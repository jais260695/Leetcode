public class Solution {
    bool IsValueNotIn(int[] forbidden, int i)
    {
        for(int j=0;j<forbidden.Count();j++)
        {
            if(forbidden[j]==i) return false;
        }
        
        return true;
    }
    
    public class Pair
    {
        public int u;
        public int flag;
        public Pair(int u1, int f1)
        {
            u = u1;
            flag = f1;
        }
    }
    
    public int MinimumJumps(int[] forbidden, int a, int b, int x) {
        bool[,] visited = new bool[2,6000];
        Queue<Pair> queue = new Queue<Pair>();
        queue.Enqueue(new Pair(0,0));
        int level =0;
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                Pair temp = queue.Dequeue();
                if(temp.u==x) return level;
                if(temp.u+a<6000 && IsValueNotIn(forbidden,temp.u+a) && !visited[0,temp.u+a] )
                {
                    queue.Enqueue(new Pair(temp.u+a,0));
                    visited[0,temp.u+a] = true;
                }
                if(temp.flag==0 && temp.u-b>0 && IsValueNotIn(forbidden,temp.u-b)  && !visited[1,temp.u-b])
                {
                    queue.Enqueue(new Pair(temp.u-b,1));
                    visited[1,temp.u-b] = true;
                }
                size--;
            }
            level++;
        }
        
        return -1;
    }
}