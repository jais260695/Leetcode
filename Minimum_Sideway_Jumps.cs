public class Solution {
    public class Position
    {
        public int lane;
        public int point;
        public int jump;
        public Position(int p, int l, int j)
        {
            lane = l;
            point = p;
            jump = j;
        }
    }
    public int MinSideJumps(int[] obstacles) {
        int N = obstacles.Count()-1;
        bool[,] visited = new bool[N+1,3];
        Queue<Position> queue = new Queue<Position>();
        queue.Enqueue(new Position(0,1,0));
        visited[0,1] = true;
        int level = 0;
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                Position p = queue.Dequeue();
                if(p.point==N) return p.jump;
                if(!visited[p.point+1,p.lane] && obstacles[p.point+1]-1 != p.lane)
                {
                    visited[p.point+1,p.lane] = true;
                    queue.Enqueue(new Position(p.point+1,p.lane,p.jump));
                }
                else
                {
                    for(int i=0;i<3;i++)
                    {
                        if(i!=p.lane && !visited[p.point,i] && obstacles[p.point]-1 != i)
                        {
                            visited[p.point,i] = true;
                            queue.Enqueue(new Position(p.point,i,p.jump+1));
                        }
                    }
                }
                size--;
            }
        }
        return 0;
    }
}