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
    public int[][] Merge(int[][] points) {
        int n = points.Count();
        List<Pair> l = new List<Pair>();
        if(n==0) return new int[n][];
        Pair[] res = new Pair[n];
        
        for(int i=0;i<n;i++)
        {
            res[i] = new Pair(points[i][0], points[i][1]);
        }
        res = res.OrderBy(a => a.u).ToArray();
        
        Pair t = new Pair(res[0].u,res[0].v);
        for(int i=1;i<n;i++)
        {           
            if(res[i].u<=t.v)
            {
                t.v =Math.Max(res[i].v,t.v);
            }
            else
            {
                l.Add(new Pair(t.u, t.v));
                t.u = res[i].u;
                t.v = res[i].v;
            }
        }
                l.Add(new Pair(t.u, t.v));
      n = l.Count();
        int[][] ans = new int[n][];
        for(int i = 0;i<n;i++)
        {
            ans[i] = new int[2];
            ans[i][0] = l[i].u;
             ans[i][1] = l[i].v;
        }
        return ans;
        
    }
}