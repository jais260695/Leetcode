public class Solution {
    public int FindKthNumber(int m, int n, int k) {
        int l = 1;
        int r = m*n;
        while(l<r)
        {
            int mid = l + (r-l)/2;
            int c = 0;
            for(int t=1;t<=m;t++)
            {
                c += Math.Min(mid/t,n);
            }
            if(c>=k)
            {
                r = mid;
            }
            else
            {
                l = mid + 1;
            }
        }
        return l;
    }
}