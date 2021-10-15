public class Solution {
    
    public class Pair
    {
        public int u;
        public int v;
        public Pair(int x, int y)
        {
            u = x;
            v = y;
        }
    }
    public int EraseOverlapIntervals(int[][] points) {
        int n = points.Count();
        if(n==0) return 0;
        Pair[] res = new Pair[n];
        
        for(int i=0;i<n;i++)
        {
            res[i] = new Pair(points[i][0], points[i][1]);
        }
        res = res.OrderBy(a => a.u).ToArray();
        
        Pair t = new Pair(res[0].u,res[0].v);
        int count = 1;
        for(int i=1;i<n;i++)
        {           
            if(res[i].u<t.v)
            {
                t.u =res[i].u;
                t.v =Math.Min(res[i].v,t.v);
            }
            else
            {
                count++;
                t.u = res[i].u;
                t.v = res[i].v;
            }
        }
        
        return n-count;
    }
}