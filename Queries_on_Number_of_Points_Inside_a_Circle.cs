public class Solution {
    public double EucledianDistance(int x1, int y1, int x2, int y2)
    {
        int x = Math.Abs(x1-x2);
        x = x*x;
        int y = Math.Abs(y1-y2);
        y = y*y;
        return (double)Math.Sqrt(x+y);
        
    }
    public int[] CountPoints(int[][] points, int[][] queries) {
        int n = queries.Count();
        int m = points.Count();
        int[] res = new int[n];
        for(int i=0;i<n;i++)
        {
            int c = 0;
            int x1 = queries[i][0];
            int y1 = queries[i][1];
            int r = queries[i][2];
            for(int j=0;j<m;j++)
            {
                if(EucledianDistance(x1,y1,points[j][0],points[j][1])<=r)
                {
                    c++;
                }
            }
            res[i] = c;
        }
        return res;
    }
}