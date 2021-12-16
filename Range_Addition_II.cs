public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        int min1 = m;
        int min2 = n;
        int h = ops.Count();
        for(int i=0;i<h;i++)
        {
             min1 = Math.Min(ops[i][0],min1);
             min2 = Math.Min(ops[i][1],min2);
        }
        return min1*min2;
    }
}