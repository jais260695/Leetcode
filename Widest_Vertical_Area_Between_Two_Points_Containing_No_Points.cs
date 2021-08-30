public class Solution {
    public class PointsCompare: IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            return a[0].CompareTo(b[0]);
        }
    }
    public int MaxWidthOfVerticalArea(int[][] points) {
        int n = points.Count();
        Array.Sort(points,new PointsCompare());
        int res = 0;
        for(int i=0;i<n-1;i++)
        {
            if(res<points[i+1][0]-points[i][0])
            {
                res = points[i+1][0]-points[i][0];
            }
        }
        return res;
    }
}